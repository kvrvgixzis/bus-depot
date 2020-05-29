using System;
using System.Drawing;
using System.Windows.Forms;

namespace bus_depot {
    public partial class AddRoute : Form {
        MongoTools database;
        public AddRoute(MongoTools database) {
            this.database = database;
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void addRouteBtn_Click(object sender, EventArgs e) {
            if (numberInput.Text.Length != 0 &&
                stPointInput.Text.Length != 0 &&
                endPointInput.Text.Length != 0 &&
                stTimeInpuut.Text.Length != 0 &&
                endTimeInput.Text.Length != 0 &&
                intervalInput.Text.Length != 0
                ) {
                string[] stTime = stTimeInpuut.Text.Split(':');
                string[] endTime = endTimeInput.Text.Split(':');

                var route = new Route {
                    Number = Convert.ToInt32(numberInput.Text),
                    StPoint = stPointInput.Text,
                    EndPoint = endPointInput.Text,
                    StTime = stTimeInpuut.Text,
                    EndTime = endTimeInput.Text,
                    Interval = Convert.ToInt32(intervalInput.Text),
                    Length = (Convert.ToInt32(endTime[0]) * 60 + Convert.ToInt32(endTime[1])) - (Convert.ToInt32(stTime[0]) * 60 + Convert.ToInt32(stTime[1]) * 10)
                };

                database.InsertDocument<Route>("routes", route);
                this.Close();
            } else {
                addRouteBtn.ForeColor = Color.FromName("red");
                addRouteBtn.Text = "Заполните обязательные поля и попробуйте снова!";
            }

        }
    }
}
