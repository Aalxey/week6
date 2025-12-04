using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal static class BookOperations
    {
        public static IEnumerable<Book> GetPremiumBooks(List<Book> books)
        {
            return books.Where(b => b.Price > 1000);
        }
        internal class Book
        {
            public string Title { get; set; }
            public double Price { get; set; }

            public Book(string title, double price)
            {
                Title = title;
                Price = price;
            }
        }
    }
}
