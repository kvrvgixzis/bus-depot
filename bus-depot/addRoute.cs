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
    public partial class AddRoute : Form
    {
        MongoTools database;
        public AddRoute(MongoTools database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRouteBtn_Click(object sender, EventArgs e)
        {
            if (numberInput.Text.Length != 0 &&
                stPointInput.Text.Length != 0 &&
                endPointInput.Text.Length != 0 &&
                stTimeInpuut.Text.Length != 0 &&
                endTimeInput.Text.Length != 0 &&
                intervalInput.Text.Length != 0
                )
            {
                var route = new Route();

                route.Number = Convert.ToInt32(numberInput.Text);
                route.StPoint = stPointInput.Text;
                route.EndPoint = endPointInput.Text;
                route.StTime = stTimeInpuut.Text;
                route.EndTime = endTimeInput.Text;
                route.Interval = Convert.ToInt32(intervalInput.Text);

                string[] stTime = stTimeInpuut.Text.Split(':');
                string[] endTime = endTimeInput.Text.Split(':');
                route.Length = (Convert.ToInt32(endTime[0]) * 60 + Convert.ToInt32(endTime[1])) - (Convert.ToInt32(stTime[0]) * 60 + Convert.ToInt32(stTime[1]));

                database.InsertDocument<Route>("routes", route);
                this.Close();
            }
            else
            {
                addRouteBtn.ForeColor = Color.FromName("red");
                addRouteBtn.Text = "Заполните обязательные поля и попробуйте снова!";
            }
            
        }
    }
}
