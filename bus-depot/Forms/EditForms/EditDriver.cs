using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bus_depot.EditForms {
    public partial class EditDriver : Form {
        readonly MongoTools database;
        readonly ObjectId id;
        readonly string collectionName;
        public EditDriver(MongoTools database, string collectionName, ObjectId id) {
            this.database = database;
            this.collectionName = collectionName;
            this.id = id;
            InitializeComponent();
        }

        [Obsolete]
        private void saveDriverBtn_Click(object sender, EventArgs e) {
            if (NameInput.Text.Length > 0 &&
                LastNameInput.Text.Length > 0 &&
                GradeInput.SelectedIndex > -1 &&
                ExpInput.Text.Length > 0 &&
                BusInput.SelectedIndex > -1 &&
                RouteInput.SelectedIndex > -1
                ) {
                var buses_doc = database.LoadAllDocuments<Bus>("buses");
                var routes_doc = database.LoadAllDocuments<Route>("routes");

                var driver = database.LoadDocumentById<Driver>(collectionName, id);

                driver.Name = NameInput.Text;
                driver.LastName = LastNameInput.Text;
                driver.Patronymic = PatronymicInput.Text;
                driver.Grade = GradeInput.SelectedIndex + 1;
                driver.Experience = Convert.ToInt32(ExpInput.Text);
                driver.BusId = buses_doc[BusInput.SelectedIndex].Id;
                driver.RouteId = routes_doc[RouteInput.SelectedIndex].Id;

                driver.Schedule.Clear();

                if (MonCheck.Checked) driver.Schedule.Add("Пн");
                if (TuesCheck.Checked) driver.Schedule.Add("Вт");
                if (WedCheck.Checked) driver.Schedule.Add("Ср");
                if (ThursCheck.Checked) driver.Schedule.Add("Чт");
                if (FriCheck.Checked) driver.Schedule.Add("Пт");
                if (SatCheck.Checked) driver.Schedule.Add("Сб");
                if (SunCheck.Checked) driver.Schedule.Add("Вс");

                driver.Salary = (2000 + 100 * driver.Experience) / driver.Grade * driver.Schedule.Count * 4;

                database.UpdateDocument<Driver>("drivers", id, driver);
                this.Close();
            } else {
                saveDriverBtn.ForeColor = Color.FromName("red");
                saveDriverBtn.Text = "Заполните обязательные поля и попробуйте снова!";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void EditDriver_Load(object sender, EventArgs e) {
            var buses_doc = database.LoadAllDocuments<Bus>("buses");
            var routes_doc = database.LoadAllDocuments<Route>("routes");

            var driver = database.LoadDocumentById<Driver>(collectionName, id);

            var drivers_bus = database.LoadDocumentById<Bus>("buses", driver.BusId);
            var drivers_route = database.LoadDocumentById<Route>("routes", driver.RouteId);

            List<string> buses_list = new List<string>();
            List<string> routes_list = new List<string>();

            foreach (var bus in buses_doc)
                buses_list.Add($"{bus.Type} {bus.Number}");
            foreach (var route in routes_doc)
                routes_list.Add($"{route.Number}: {route.StPoint} — {route.EndPoint}");

            string[] buses_array = buses_list.ToArray();
            string[] routes_array = routes_list.ToArray();

            BusInput.Items.AddRange(buses_array);
            RouteInput.Items.AddRange(routes_array);

            LastNameInput.Text = driver.LastName.ToString();
            NameInput.Text = driver.Name.ToString();
            PatronymicInput.Text = driver.Patronymic.ToString();
            GradeInput.Text = driver.Grade.ToString() + " класс";
            ExpInput.Text = driver.Experience.ToString();
            BusInput.Text = $"{drivers_bus.Type} {drivers_bus.Number}";
            RouteInput.Text = $"{drivers_route.Number}: {drivers_route.StPoint} — {drivers_route.EndPoint}";

            MonCheck.Checked = (driver.Schedule.Contains("Пн"));
            TuesCheck.Checked = (driver.Schedule.Contains("Вт"));
            WedCheck.Checked = (driver.Schedule.Contains("Ср"));
            ThursCheck.Checked = (driver.Schedule.Contains("Чт"));
            FriCheck.Checked = (driver.Schedule.Contains("Пт"));
            SatCheck.Checked = (driver.Schedule.Contains("Сб"));
            SunCheck.Checked = (driver.Schedule.Contains("Вс"));
        }
    }
}
