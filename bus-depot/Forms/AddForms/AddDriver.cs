using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bus_depot {
    public partial class AddDriver : Form {
        MongoTools database;
        public AddDriver(MongoTools database) {
            this.database = database;
            InitializeComponent();
        }

        private void AddDriver_Load(object sender, EventArgs e) {
            var buses_doc = database.LoadAllDocuments<Bus>("buses");
            var routes_doc = database.LoadAllDocuments<Route>("routes");

            List<string> buses_list = new List<string>();
            List<string> routes_list = new List<string>();

            foreach (var bus in buses_doc) {
                buses_list.Add($"{bus.Type} {bus.Number}");
            }
            foreach (var route in routes_doc) {
                routes_list.Add($"{route.Number}: {route.StPoint} — {route.EndPoint}");
            }

            string[] buses_array = buses_list.ToArray();
            string[] routes_array = routes_list.ToArray();

            BusInput.Items.AddRange(buses_array);
            RouteInput.Items.AddRange(routes_array);
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void addDriverBtn_Click(object sender, EventArgs e) {
            if (NameInput.Text.Length > 0 &&
                LastNameInput.Text.Length > 0 &&
                GradeInput.SelectedIndex > -1 &&
                ExpInput.Text.Length > 0 &&
                BusInput.SelectedIndex > -1 &&
                RouteInput.SelectedIndex > -1
                ) {
                var buses_doc = database.LoadAllDocuments<Bus>("buses");
                var routes_doc = database.LoadAllDocuments<Route>("routes");
                var driver = new Driver {
                    Name = NameInput.Text,
                    LastName = LastNameInput.Text,
                    Patronymic = PatronymicInput.Text,
                    Grade = GradeInput.SelectedIndex + 1,
                    Experience = Convert.ToInt32(ExpInput.Text),
                    BusId = buses_doc[BusInput.SelectedIndex].Id,
                    RouteId = routes_doc[RouteInput.SelectedIndex].Id
                };

                if (MonCheck.Checked) driver.Schedule.Add("Пн");
                if (TuesCheck.Checked) driver.Schedule.Add("Вт");
                if (WedCheck.Checked) driver.Schedule.Add("Ср");
                if (ThursCheck.Checked) driver.Schedule.Add("Чт");
                if (FriCheck.Checked) driver.Schedule.Add("Пт");
                if (SatCheck.Checked) driver.Schedule.Add("Сб");
                if (SunCheck.Checked) driver.Schedule.Add("Вс");

                driver.Salary = (2000 + 100 * driver.Experience) / driver.Grade * driver.Schedule.Count * 4;


                database.InsertDocument<Driver>("drivers", driver);
                this.Close();
            } else {
                addDriverBtn.ForeColor = Color.FromName("red");
                addDriverBtn.Text = "Заполните обязательные поля и попробуйте снова!";
            }
        }
    }
}
