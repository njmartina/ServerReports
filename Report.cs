using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerReports
{
    class Report
    {
        //Reports consisnt of sales figures, guest count, and whether it was a dinne or lunch shift
        public double FoodSales { get; set; }
        public double LiquorSales { get; set; }
        public double BeerSales { get; set; }
        public double WineSales { get; set; }
        public double BevSales { get; set; }
        public int GuestCount { get; set; }
        public int TotalTips { get; set; }
        public string ShiftType { get; set; }

        //Constructor
        public Report(double foodSales, double liquorSales, double beerSales, double wineSales, double bevSales, int guestCount, int totalTips, string shiftType)
        {
            FoodSales = foodSales;
            LiquorSales = liquorSales;
            BeerSales = beerSales;
            WineSales = wineSales;
            BevSales = bevSales;
            GuestCount = guestCount;
            TotalTips = totalTips;
            ShiftType = shiftType;
        }

        //Empty constructor
        public Report()
        {
            //TODO not sure what to put in here
        }

        //Calcualtes the total sales from each category
        public double CalculateTotalSales() => FoodSales + LiquorSales + BeerSales + WineSales + BevSales;

        //Calculates the sales tax of the total sales figure
        public double CalculateTotalTaxes() => CalculateTotalSales() * 0.06;

        //ToString override to print report information
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("============ SALES TOTALS ============\n");
            sb.Append($"Food: {FoodSales}\n");
            sb.Append($"Liquor: {LiquorSales}\n");
            sb.Append($"Beer: {BeerSales}\n");
            sb.Append($"Wine: {WineSales}\n");
            sb.Append($"Beverage: {BevSales}\n");

            return sb.ToString();
        }

    }
}
