using System;
using System.Drawing;
using System.Windows.Forms;

namespace bus_depot {
    public partial class AddBus : Form {
        MongoTools database;
        public AddBus(MongoTools database) {
            this.database = database;
            InitializeComponent();
        }

        private void addBusBtn_Click(object sender, EventArgs e) {
            if (numberInput.Text.Length != 0 &&
                typeInput.SelectedIndex > -1 &&
                capacityInput.Text.Length != 0) {
                var bus = new Bus {
                    Number = numberInput.Text,
                    Type = typeInput.Text,
                    Сapacity = Convert.ToInt32(capacityInput.Text),
                    IsWorking = (isWorkingInput.SelectedIndex == 0)
                };

                database.InsertDocument<Bus>("buses", bus);
                this.Close();
            } else {
                addBusBtn.ForeColor = Color.FromName("red");
                addBusBtn.Text = "Заполните обязательные поля и попробуйте снова!";
            }
        }

        private void AddBus_Load(object sender, EventArgs e) {
            isWorkingInput.SelectedIndex = 0;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
