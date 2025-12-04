using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class TourBooking
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDay { get; set; }
        public bool IsInternational { get; set; }

        public TourBooking(string customerName, string destination, double price, int duration, bool isInternational)
        {
            CustomerName = customerName;
            Destination = destination;
            Price = price;
            DurationInDay = duration;
            IsInternational = isInternational;
        }
    }
}
