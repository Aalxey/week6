using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class CashierSales
    {
        public string Name { get; set; }
        public double Sales { get; set; }

        public CashierSales(string name, double sales)
        {
            Name = name;
            Sales = sales;
        }
        internal static class SalesOperations
        {
            public static void DisplayAggregates(List<CashierSales> salesList)
            {
                int totalCashiers = salesList.Count;
                double totalSales = salesList.Sum(c => c.Sales);
                double highestSale = salesList.Max(c => c.Sales);
                double lowestSale = salesList.Min(c => c.Sales);
                double averageSale = salesList.Average(c => c.Sales);

                Console.WriteLine("Aggregation Operators:");
                Console.WriteLine($"Total Cashiers: {totalCashiers}");
                Console.WriteLine($"Total Sales: Rs.{totalSales}");
                Console.WriteLine($"Highest Sale: Rs.{highestSale}");
                Console.WriteLine($"Lowest Sale: Rs.{lowestSale}");
                Console.WriteLine($"Average Sale: Rs.{averageSale}\n");
            }
        }
    }
}
