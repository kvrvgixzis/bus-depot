using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace bus_depot.Forms {
    public partial class ReportForm : Form {
        readonly DataGridView grid;
        readonly MongoTools database;
        readonly string collectionName;


        public ReportForm(MongoTools database, DataGridView grid, string collectionName) {
            this.grid = grid;
            this.database = database;
            this.collectionName = collectionName;
            InitializeComponent();
        }


        private string getHtmlTable(DataGridView grid) {
            string htmlTable = "<table cellpadding='5' cellspacing='0'>";

            htmlTable += "<tr class='table__header'>";
            foreach (DataGridViewColumn column in grid.Columns) {
                if (grid.Columns[0] == column) continue; // skip ID column
                htmlTable += $"<th>{column.HeaderText}</th>";
            }
            htmlTable += "</tr>";

            int iterator = 0;
            foreach (DataGridViewRow row in grid.Rows) {
                string className = iterator % 2 == 0 ? "light" : "dark";
                htmlTable += $"<tr class=\"{className}\">";
                foreach (DataGridViewCell cell in row.Cells) {
                    if (row.Cells[0] == cell) continue; // skip ID column
                    htmlTable += $"<td>{cell.Value}</td>";
                }
                htmlTable += "</tr>";
                iterator++;
            }
            htmlTable += "</table>";

            return htmlTable;
        }


        private string getHtmlData(MongoTools database, string collectionName) {
            string htmlData = "";

            if (collectionName == "drivers") {
                List<Driver> drivers = database.LoadAllDocuments<Driver>("drivers");

                int count = drivers.Count();

                DateTime dt = DateTime.Now;
                string dayOfWeek = dt.ToString("ddd");
                int withWorkingBusesCount = drivers.Where(driver => database.LoadDocumentById<Bus>("buses", driver.BusId).IsWorking ).Count();
                
                List<Driver> todayWorkingList = drivers.Where(driver => driver.Schedule.Contains(dayOfWeek)).ToList();
                int todayWorkingCount = todayWorkingList.Count();
                string todayWorkingHtml = "";

                foreach (Driver driver in todayWorkingList) {
                    Bus bus = database.LoadDocumentById<Bus>("buses", driver.BusId);
                    todayWorkingHtml += $"<div class=\"drivers__drivers\">{driver.LastName} {driver.Name}: <span>{bus.Number}</span></div>";
                }
                htmlData = $"<div class=\"data__block\"><span>Количество водителей: </span> {count}</div>" +
                            $"<div class=\"data__block\"><span>Количество водителей с работающими автобусами: </span> {withWorkingBusesCount}</div>" +
                            $"<div class=\"data__block\"><span>Сегодня работает водителей: </span> {todayWorkingCount}</div>" +
                            $"<div class=\"data__block\"><span>Сегодня работают: </span> {todayWorkingHtml}</div>";

            } else if (collectionName == "buses") {
                List<Bus> buses = database.LoadAllDocuments<Bus>("buses");

                int count = buses.Count();
                int workingCount = buses.Where(bus => bus.IsWorking).Count();

                int maxEndTime = 0;
                string maxEndTimeStr = "";
                string driversList = "";

                foreach (var bus in buses) {
                    List<Driver> drivers = database.LoadAllDocuments<Driver>("drivers");
                    Driver driver = drivers.Find(d => d.BusId == bus.Id);

                    if (driver != null) {
                        ObjectId routeId = driver.RouteId;

                        Route route = database.LoadDocumentById<Route>("routes", routeId);

                        driversList += $"<div class='bus__drivers'><span>{bus.Number}</span>: {driver.LastName} {driver.Name}</div>";
                        
                        string endTimeStr = route.EndTime;
                        int endTime = Convert.ToInt32(endTimeStr[0]) + Convert.ToInt32(endTimeStr[1]);

                        if (endTime > maxEndTime) {
                            maxEndTime = endTime;
                            maxEndTimeStr = endTimeStr;
                        }
                    }
                }
                htmlData = $"<div class=\"data__block\"><span>Количество автобусов:</span> {count}</div>" +
                            $"<div class=\"data__block\"><span>Количество сломанных автобусов:</span> {count - workingCount}</div>" +
                            $"<div class=\"data__block\"><span>Последний автобус приедет в:</span> {maxEndTimeStr}</div>" +
                            $"<div class=\"data__block\"><span>Список водителей:</span> {driversList}</div>";

            } else if (collectionName == "routes") {
                List<Route> routes = database.LoadAllDocuments<Route>("routes");
                List<Driver> drivers = database.LoadAllDocuments<Driver>("drivers");
                List<Bus> buses = database.LoadAllDocuments<Bus>("buses");

                int count = routes.Count();

                string busesByRoutesCountHtml = "";

                foreach (Route route in routes) {
                    List<Driver> driversByRoute = drivers.Where(driver => driver.RouteId == route.Id).ToList();
                    int driversByRouteCount = driversByRoute.Count;
                    if (driversByRouteCount > 0) {
                        busesByRoutesCountHtml += $"<div class=\"bold tab\">Автобусы на маршруте {route.Number} ({driversByRouteCount} автобусов): </div>";

                        foreach (Driver driver in driversByRoute) {
                            Bus bus = database.LoadDocumentById<Bus>("buses", driver.BusId);
                            busesByRoutesCountHtml += $"<div class=\"routes__drivers\">{driver.LastName}: <span>{bus.Number}</span></div>";
                        }
                    }
                }
                htmlData = $"<div class=\"data__block\"><span>Количество маршрутов:</span> {count}</div>" +
                            $"<div class=\"data__block\"><span>Маршруты:</span> {busesByRoutesCountHtml}</div>";

            }
            return htmlData;
        }


        private string getReportType(string collectionName) {
            string type = "";
            if (collectionName == "drivers")
                type = "Водители";
            else if (collectionName == "buses")
                type = "Автобусы";
            else if (collectionName == "routes")
                type = "Маршруты";
            return type;
        }


        private void ReportForm_Load(object sender, EventArgs e) {
            string templatePath = "../../HtmlTemplates/report.html";
            var template = new HtmlTemplate(templatePath);
            var output = template.Render(new {
                type = getReportType(collectionName),
                grid = getHtmlTable(grid),
                data = getHtmlData(database, collectionName),
            });
            webBrowser.DocumentText = output;
        }

        
        private void printBtn_Click(object sender, EventArgs e) {
            webBrowser.ShowPrintDialog();
        }
    }
}