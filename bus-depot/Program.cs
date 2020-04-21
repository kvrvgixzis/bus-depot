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
            var connectionString = $"mongodb://{login}:{pwd}@localhost:27017/?authSource=bus_depot";
            const string databaseName = "bus_depot";
            MongoTools database = new MongoTools(connectionString, databaseName);
            return database;
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            //const string driversCollection = "drivers";
            //const string routesCollection = "routes";
            //const string busesCollection = "buses";
        }
    }
}
