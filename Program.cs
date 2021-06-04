using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ServerReports
{
    class Program
    {
        static void Main(string[] args)
        {
            var nicolo = Controller.CreateServer("Nicolo", "Martina", new DateTime(1994, 1, 11));
            Console.WriteLine(nicolo.ToString());

            var report = Controller.CreateReport(400, 100, 20, 23, 15.50, 24, 200, "Lunch");
            Console.WriteLine(report.ToString());
            Console.ReadLine();
        }
    }
}
