using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_depot
{
    static class Program
    {
        static public MongoTools Login(string login, string pwd)
        {
            var connectionString = $"mongodb://{login}:{pwd}@94.230.138.242:49563/?authSource=bus_depot";
            const string databaseName = "bus_depot";
            MongoTools database = new MongoTools(connectionString, databaseName);
            return database;
        }
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
