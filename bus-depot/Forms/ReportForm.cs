using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;


namespace bus_depot.Forms
{
    public partial class ReportForm : Form
    {
        readonly DataGridView grid;
        readonly MongoTools database;
        readonly string collectionName;
        public ReportForm(MongoTools database, DataGridView grid, string collectionName)
        {
            this.grid = grid;
            this.collectionName = collectionName;
            InitializeComponent();
        }
        private string getHtmlTable(DataGridView grid)
        {
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";
            html += "<tr>";
            int i = 0;
            foreach (DataGridViewColumn column in grid.Columns)
            {
                if (i == 0)
                {
                    i++;
                    continue;
                }
                html += "<th style='border: 1px solid #ccc'>" + column.HeaderText + "</th>";
                i++;
            }
            html += "</tr>";
            foreach (DataGridViewRow row in grid.Rows)
            {
                i = 0;
                html += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (i == 0)
                    {
                        i++;
                        continue;
                    }
                    html += "<td style='width:120px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>";
                }
                html += "</tr>";
                i++;
            }
            html += "</table>";
            return html;
        }
        private string getHtmlData(MongoTools database, string collectionName)
        {
            string data = "";
            if (collectionName == "drivers")
            {

            }
            else if (collectionName == "buses") 
            {
                var buses = database.LoadAllDocuments<Bus>("buses");

                int count = buses.Count();
                int workingCount = buses.Where(bus => bus.IsWorking).Count();
                int maxEndTime = 0;

                string maxEndTimeStr = "";
                string[] drivers = { };

                foreach (var bus in buses)
                {
                    var driver = database.LoadDocumentById<Driver>("drivers", bus.Id);
                    ObjectId routeId = driver.RouteId;
                    var route = database.LoadDocumentById<Route>("routes", routeId);
                    string endTimeStr = route.EndTime;
                    int endTime = Convert.ToInt32(endTimeStr[0]) + Convert.ToInt32(endTimeStr[1]);

                    drivers.Append($"{bus.Number}: {driver.LastName} {driver.Name}");
                    if (endTime > maxEndTime)
                    {
                        maxEndTime = endTime;
                        maxEndTimeStr = endTimeStr;
                    }
                }

                data = $"<div> Количество автобусов: {count}</div>" +
                    $"<div>Количество сломанных автобусов: {count - workingCount}</div>" +
                    $"<div>Последний автобус приедет в: {maxEndTimeStr}</div>" +
                    $"<div>Список водителей: {drivers}</div>";
            } 
            else if (collectionName == "routes")
            {

            }
            

            return data;
        }
        private string getReportType(string collectionName)
        {
            string type = "";
            if (collectionName == "drivers")
                type = "Водители";
            else if (collectionName == "buses")
                type = "Автобусы";
            else if (collectionName == "routes")
                type = "Маршруты";
            return type;
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            string templatePath = "../../HtmlTemplates/report.html";
            var template = new HtmlTemplate(templatePath);
            var output = template.Render(new
            {
                type = getReportType(collectionName),
                grid = getHtmlTable(grid),
                data = getHtmlData(database, collectionName),
            });
            webBrowser.DocumentText = output;
        }
        private void printBtn_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPrintDialog();
        }
    }
}