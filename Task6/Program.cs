namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TourBooking> bookings = new List<TourBooking>
            {
                new TourBooking("Alice", "Paris", 15000, 5, true),
                new TourBooking("Bob", "Kathmandu", 8000, 3, false),
                new TourBooking("Charlie", "New York", 12000, 6, true),
                new TourBooking("David", "Pokhara", 11000, 4, false),
                new TourBooking("Eve", "Thailand", 9500, 5, true),
                new TourBooking("Frank", "Chitwan", 13000, 5, false)
            };

            List<SummaryReportItem> report = TourOperations.GenerateSummaryReport(bookings);

            TourOperations.DisplaySummaryReport(report);
        }
    }
}
