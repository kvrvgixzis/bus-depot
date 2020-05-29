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
    public partial class EditBus : Form
    {
        readonly MongoTools database;
        readonly ObjectId id;
        readonly string collectionName;
        public EditBus(MongoTools database, string collectionName, ObjectId id)
        {
            this.database = database;
            this.collectionName = collectionName;
            this.id = id;
            InitializeComponent();
        }

        [Obsolete]
        private void saveBusBtn_Click(object sender, EventArgs e)
        {
            var bus = database.LoadDocumentById<Bus>(collectionName, id);

            if (numberInput.Text.Length != 0 &&
                typeInput.SelectedIndex > -1 &&
                capacityInput.Text.Length != 0)
            {
                bus.Number = numberInput.Text;
                bus.Type = typeInput.Text;
                bus.Сapacity = Convert.ToInt32(capacityInput.Text);
                bus.IsWorking = (isWorkingInput.SelectedIndex == 0);
                database.UpdateDocument<Bus>(collectionName, id, bus);
                this.Close();
            }
            else
            {
                saveBusBtn.ForeColor = Color.FromName("red");
                saveBusBtn.Text = "Заполните обязательные поля и попробуйте снова!";
            }
        }

        private void EditBus_Load(object sender, EventArgs e)
        {
            var bus = database.LoadDocumentById<Bus>(collectionName, id);

            numberInput.Text = bus.Number;
            typeInput.Text = bus.Type;
            capacityInput.Text = Convert.ToString(bus.Сapacity);
            isWorkingInput.SelectedIndex = bus.IsWorking ? 0 : 1;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
