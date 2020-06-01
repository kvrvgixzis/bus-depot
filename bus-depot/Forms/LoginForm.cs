using System;
using System.Drawing;
using System.Windows.Forms;

namespace bus_depot {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }


        private void loginBtn_Click(object sender, EventArgs e) {
            string login = loginInput.Text;
            string pwd = pwdInput.Text;

            MongoTools database = Program.Login(login, pwd);

            if (MongoTools.isConnect) {

                if (login == "admin") {
                    MongoTools.isAdmin = true;
                }

                MainForm mainForm = new MainForm(database);
                mainForm.Show();
                this.Hide();
            } else {
                
                loginBtn.ForeColor = Color.FromName("red");
                loginBtn.Text = "Неверный логин или пароль. Попробуйте снова!";
            }
        }
    }
}
