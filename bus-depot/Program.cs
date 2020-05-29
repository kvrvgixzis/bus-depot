using System;
using System.IO;
using System.Windows.Forms;

namespace bus_depot {
    public class HtmlTemplate {
        private string _html;

        public HtmlTemplate(string templatePath) {
            using (var reader = new StreamReader(templatePath))
                _html = reader.ReadToEnd();
        }

        public string Render(object values) {
            string output = _html;
            foreach (var p in values.GetType().GetProperties())
                output = output.Replace("[" + p.Name + "]", (p.GetValue(values, null) as string) ?? string.Empty);
            return output;
        }
    }
    static class Program {

        static public MongoTools Login(string login, string pwd) {
            var connectionString = $"mongodb://{login}:{pwd}@94.230.138.242:49563/?authSource=bus_depot";
            const string databaseName = "bus_depot";
            MongoTools database = new MongoTools(connectionString, databaseName);
            return database;
        }

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
