using static Task5.Applicant;
using static Task5.CashierSales;
using static Task5.Music;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CashierSales> salesList = new List<CashierSales>
            {
                new CashierSales("Cashier1", 5000),
                new CashierSales("Cashier2", 7000),
                new CashierSales("Cashier3", 4500),
                new CashierSales("Cashier4", 6000)
            };
            SalesOperations.DisplayAggregates(salesList);

            List<Applicant> applicants = new List<Applicant>
            {
                new Applicant("Alice", 17),
                new Applicant("Bob", 20),
                new Applicant("Charlie", 15),
                new Applicant("David", 18)
            };
            ApplicantOperations.DisplayQuantifiers(applicants);

            List<Music> songs = new List<Music>
            {
                new Music("Song1", 180),
                new Music("Song2", 250),
                new Music("Song3", 300),
                new Music("Song4", 420),
                new Music("Song5", 600)
            };
            MusicOperations.DisplayElements(songs);
        }
    }
}
