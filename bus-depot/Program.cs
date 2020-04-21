using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bus_depot
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            // By default for a local MongoDB instance connectionString = "mongodb://localhost:27017"
 
            var connectionString = "mongodb://localhost:27017";
            const string databaseName = "bus_depot";
            const string driversCollection = "drivers";
            const string routesCollection = "routes";
            const string busesCollection = "buses";

            MongoTools database = new MongoTools(connectionString, databaseName);
        }
    }
}
