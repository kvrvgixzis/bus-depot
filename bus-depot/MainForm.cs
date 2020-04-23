using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_depot
{
    public partial class MainForm : Form
    {
        MongoTools database;
        private void ShowRoutes()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            Table.Refresh();

            var documents = database.LoadAllDocuments<Route>("routes");

            Table.ColumnCount = 7;

            Table.Columns[0].Name = "Number";
            Table.Columns[1].Name = "Start Point";
            Table.Columns[2].Name = "End Point";
            Table.Columns[3].Name = "Start Time";
            Table.Columns[4].Name = "End Time";
            Table.Columns[5].Name = "Interval";
            Table.Columns[6].Name = "Length";

            foreach (var doc in documents)
            {
                string number = Convert.ToString(doc.Number);
                string stPoint = Convert.ToString(doc.StPoint);
                string endPoint = Convert.ToString(doc.EndPoint);
                string stTime = Convert.ToString(doc.StTime);
                string endTime = Convert.ToString(doc.EndTime);
                string interval = Convert.ToString(doc.Interval);
                string lenght = Convert.ToString(doc.Length);

                string[] row = { number, stPoint, endPoint, stTime, endTime, interval, lenght };
                
                Table.Rows.Add(row);
            }
        }
        private void ShowBuses()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            Table.Refresh();

            var documents = database.LoadAllDocuments<Bus>("buses");

            Table.ColumnCount = 5;

            Table.Columns[0].Name = "Number";
            Table.Columns[1].Name = "Type";
            Table.Columns[2].Name = "Capacity";
            Table.Columns[3].Name = "Driver";
            Table.Columns[4].Name = "Is Working";

            foreach (var doc in documents)
            {
                string number = doc.Number;
                string type = doc.Type;
                string capacity = Convert.ToString(doc.Сapacity);
                string driver = (Convert.ToString(doc.DriverId) == "000000000000000000000000") ? "-" : Convert.ToString(doc.DriverId);
                string isWorking = Convert.ToString(doc.IsWorking);

                string[] row = { number, type, capacity, driver, isWorking };

                Table.Rows.Add(row);
            }
        }

        private void ShowDrivers()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            Table.Refresh();

            var documents = database.LoadAllDocuments<Driver>("drivers");

            Table.ColumnCount = 7;

            Table.Columns[0].Name = "Full Name";
            Table.Columns[1].Name = "Grade";
            Table.Columns[2].Name = "Experience";
            Table.Columns[3].Name = "Salary";
            Table.Columns[4].Name = "Bus";
            Table.Columns[5].Name = "Route";
            Table.Columns[6].Name = "Schedule";

            foreach (var doc in documents)
            {
                string fullName = $"{doc.LastName} {doc.Name} {doc.Patronymic}";
                string grade = Convert.ToString(doc.Grade);
                string exp = Convert.ToString(doc.Experience);
                string sal = Convert.ToString(doc.Salary);
                string bus = (Convert.ToString(doc.BusId) == "000000000000000000000000") ? "-" : Convert.ToString(doc.BusId);
                string route = (Convert.ToString(doc.RouteId) == "000000000000000000000000") ? "-" : Convert.ToString(doc.RouteId);
                string schedule = "";
                foreach (var day in doc.Schedule)
                {
                    schedule += $" {day}";
                }

                string[] row = { fullName, grade, exp, sal, bus, route, schedule };

                Table.Rows.Add(row);
            }
        }
        public MainForm(MongoTools database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowBuses();
        }

        private void ShowBusesBtn_Click(object sender, EventArgs e)
        {
            ShowBuses();
            AddNewElementBtn.Text = "Add new bus";
        }

        private void ShowRoutesBtn_Click(object sender, EventArgs e)
        {
            ShowRoutes();
            AddNewElementBtn.Text = "Add new route";
        }

        private void ShowDriversBtn_Click(object sender, EventArgs e)
        {
            ShowDrivers();
            AddNewElementBtn.Text = "Add new driver";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
