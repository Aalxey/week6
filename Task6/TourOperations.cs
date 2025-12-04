using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal static class TourOperations
    {
        public static List<SummaryReportItem> GenerateSummaryReport(List<TourBooking> bookings)
        {
            var filtered = bookings
                .Where(b => b.Price > 10000 && b.DurationInDay > 4)
                .Select(b => new SummaryReportItem(
                    b.CustomerName,
                    b.Destination,
                    b.IsInternational ? "International" : "Domestic",
                    b.Price))
                .OrderBy(b => b.Category) 
                .ThenBy(b => b.Price)
                .ToList();

            return filtered;
        }
        public static void DisplaySummaryReport(List<SummaryReportItem> report)
        {
            Console.WriteLine("Summary Report:");
            foreach (var item in report)
            {
                Console.WriteLine($"Customer: {item.CustomerName}");
                Console.WriteLine($"Destination: {item.Destination}");
                Console.WriteLine($"Category: {item.Category}");
                Console.WriteLine($"Price: Rs.{item.Price}");
            }
        }
    }
}
