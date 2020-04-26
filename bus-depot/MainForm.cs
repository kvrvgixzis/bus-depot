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


namespace bus_depot
{
    public partial class MainForm : Form
    {
        MongoTools database;
        private string collectionName;
        private void ShowRoutes()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            Table.Refresh();

            collectionName = "routes";
            AddNewElementBtn.Text = "Новый маршрут";

            var documents = database.LoadAllDocuments<Route>("routes");

            Table.ColumnCount = 8;

            Table.Columns[0].Name = "ID";
            Table.Columns[0].Visible = false;

            Table.Columns[1].Name = "Номер";
            Table.Columns[2].Name = "От";
            Table.Columns[3].Name = "До";
            Table.Columns[4].Name = "Со скольки";
            Table.Columns[5].Name = "До скольки";
            Table.Columns[6].Name = "Интервал";
            Table.Columns[7].Name = "Длинна";

            foreach (var doc in documents)
            {
                string ID = Convert.ToString(doc.Id);

                string number = Convert.ToString(doc.Number);
                string stPoint = Convert.ToString(doc.StPoint);
                string endPoint = Convert.ToString(doc.EndPoint);
                string stTime = Convert.ToString(doc.StTime);
                string endTime = Convert.ToString(doc.EndTime);
                string interval = Convert.ToString(doc.Interval);
                string lenght = Convert.ToString(doc.Length);

                string[] row = { ID, number, stPoint, endPoint, stTime, endTime, interval, lenght };
                
                Table.Rows.Add(row);
            }
        }
        private void ShowBuses()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            Table.Refresh();

            collectionName = "buses";
            AddNewElementBtn.Text = "Новый автобус";

            var documents = database.LoadAllDocuments<Bus>("buses");

            Table.ColumnCount = 6;

            Table.Columns[0].Name = "ID";
            Table.Columns[0].Visible = false;

            Table.Columns[1].Name = "Номер";
            Table.Columns[2].Name = "Тип";
            Table.Columns[3].Name = "Мест";
            Table.Columns[4].Name = "Водитель";
            Table.Columns[5].Name = "Исправность";

            foreach (var doc in documents)
            {
                string ID = Convert.ToString(doc.Id);

                string number = doc.Number;
                string type = doc.Type;
                string capacity = Convert.ToString(doc.Сapacity);
                string driver = (Convert.ToString(doc.DriverId) == "000000000000000000000000") ? "-" : Convert.ToString(doc.DriverId);
                string isWorking = Convert.ToString(doc.IsWorking);

                string[] row = { ID, number, type, capacity, driver, isWorking };

                Table.Rows.Add(row);
            }
        }

        private void ShowDrivers()
        {
            Table.Rows.Clear();
            Table.Columns.Clear();
            Table.Refresh();

            collectionName = "drivers";
            AddNewElementBtn.Text = "Новый водитель";

            var documents = database.LoadAllDocuments<Driver>("drivers");

            Table.ColumnCount = 8;

            Table.Columns[0].Name = "ID";
            Table.Columns[0].Visible = false;

            Table.Columns[1].Name = "ФИО";
            Table.Columns[2].Name = "Класс";
            Table.Columns[3].Name = "Стаж";
            Table.Columns[4].Name = "ЗП";
            Table.Columns[5].Name = "Автобус";
            Table.Columns[6].Name = "Маршрут";
            Table.Columns[7].Name = "График";

            foreach (var doc in documents)
            {
                string ID = Convert.ToString(doc.Id);

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

                string[] row = { ID, fullName, grade, exp, sal, bus, route, schedule };

                Table.Rows.Add(row);
            }
        }
        public MainForm(MongoTools database)
        {
            this.database = database;
            InitializeComponent();
            if (!MongoTools.isAdmin)
            {
                AddNewElementBtn.Visible = false;
                editSelectBtn.Visible = false;
                deleteSelectedBtn.Visible = false;
            }
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
        }

        private void ShowRoutesBtn_Click(object sender, EventArgs e)
        {
            ShowRoutes();
        }

        private void ShowDriversBtn_Click(object sender, EventArgs e)
        {
            ShowDrivers();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteSelectedBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить выделенный элемент?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string str_id = Table.SelectedRows[0].Cells[0].Value.ToString();
                ObjectId id = MongoDB.Bson.ObjectId.Parse(str_id);
                if (collectionName == "buses") {
                    database.DeleteDocument<Bus>(collectionName, id);
                    ShowBuses();
                } else if (collectionName == "routes") {
                    database.DeleteDocument<Route>(collectionName, id);
                    ShowRoutes();
                } else if (collectionName == "drivers") {
                    database.DeleteDocument<Driver>(collectionName, id);
                    ShowDrivers();
                }
                MessageBox.Show("Элемент удален");
            }
        }

        private void ReloginBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void AddNewElementBtn_Click(object sender, EventArgs e)
        {
            if (collectionName == "buses") {

            } else if (collectionName == "routes") {
                addRoute form = new addRoute(database);
                form.ShowDialog();
                ShowRoutes();
                MessageBox.Show("Маршрут добавлен");
            }
            else if (collectionName == "drivers") {

            }
        }
    }
}