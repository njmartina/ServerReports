using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ServerReports
{
    class Program
    {
        static void Main(string[] args)
        {
            var mark = Controller.CreateServer("Mark", "Martina", new DateTime(1961, 6, 6));

            var report = Controller.CreateReport(400, 100, 20, 23, 15.50, 24, 200, "Lunch");
            Console.WriteLine(report.ToString());

            SQLiteAccess.SaveServer(mark);

            Controller.DisplayServers();
            Console.ReadLine();
        }
    }
}
