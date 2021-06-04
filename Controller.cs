using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerReports
{
    class Controller
    {
        public static Server CreateServer(string firstName, string lastName, DateTime dateOfBirth)
        {
            return new Server(firstName, lastName, dateOfBirth);
        }

        public static Report CreateReport(double foodSales, double liquorSales, double beerSales, double wineSales, double bevSales, int guestCount, int totalTips, string shiftType)
        {
            return new Report(foodSales, liquorSales, beerSales, wineSales, bevSales, guestCount, totalTips, shiftType);
        }
    }
}
