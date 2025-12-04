using static Task4.BookOperations;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            var squaredNumbers = NumberOperations.SquareNumbers(numbers);

            Console.WriteLine("Squared Numbers:");
            foreach (var n in squaredNumbers)
                Console.WriteLine(n);

            List<Book> books = new List<Book>
            {
                new Book("C# Basics", 800),
                new Book("LINQ Mastery", 1500),
                new Book("ASP.NET Core", 2200)
            };

            var premiumBooks = BookOperations.GetPremiumBooks(books);
            Console.WriteLine("\nPremium Books:");
            foreach (var b in premiumBooks)
                Console.WriteLine(b.Title + " - Rs." + b.Price);

            List<Student> students = new List<Student>
            {
                new Student("Bishal"),
                new Student("Aakash"),
                new Student("Nikita"),
                new Student("Zara")
            };

            var sortedStudents = StudentOperations.SortStudentsByName(students);
            Console.WriteLine("\nSorted Students:");
            foreach (var s in sortedStudents)
                Console.WriteLine(s.Name);
        }
    }
}
