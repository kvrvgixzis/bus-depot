using MongoDB.Bson;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace bus_depot.EditForms {

    public partial class EditRoute : Form {
        readonly MongoTools database;
        readonly ObjectId id;
        readonly string collectionName;
        public EditRoute(MongoTools database, string collectionName, ObjectId id) {
            this.database = database;
            this.collectionName = collectionName;
            this.id = id;
            InitializeComponent();
        }

        private void EditRoute_Load(object sender, EventArgs e) {
            var route = database.LoadDocumentById<Route>(collectionName, id);

            numberInput.Text = route.Number.ToString();
            stPointInput.Text = route.StPoint.ToString();
            endPointInput.Text = route.EndPoint.ToString();
            stTimeInpuut.Text = route.StTime.ToString();
            endTimeInput.Text = route.EndTime.ToString();
            intervalInput.Text = route.Interval.ToString();
        }

        [Obsolete]
        private void saveRouteBtn_Click(object sender, EventArgs e) {
            if (numberInput.Text.Length != 0 &&
                stPointInput.Text.Length != 0 &&
                endPointInput.Text.Length != 0 &&
                stTimeInpuut.Text.Length != 0 &&
                endTimeInput.Text.Length != 0 &&
                intervalInput.Text.Length != 0
                ) {
                string[] stTime = stTimeInpuut.Text.Split(':');
                string[] endTime = endTimeInput.Text.Split(':');

                var route = database.LoadDocumentById<Route>(collectionName, id);

                route.Number = Convert.ToInt32(numberInput.Text);
                route.StPoint = stPointInput.Text;
                route.EndPoint = endPointInput.Text;
                route.StTime = stTimeInpuut.Text;
                route.EndTime = endTimeInput.Text;
                route.Interval = Convert.ToInt32(intervalInput.Text);
                route.Length = (((Convert.ToInt32(endTime[0]) * 60 + Convert.ToInt32(endTime[1])) - (Convert.ToInt32(stTime[0]) * 60 + Convert.ToInt32(stTime[1]))) * 10);

                database.UpdateDocument<Route>("routes", id, route);
                this.Close();
            } else {
                saveRouteBtn.ForeColor = Color.FromName("red");
                saveRouteBtn.Text = "Заполните обязательные поля и попробуйте снова!";
            }
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
