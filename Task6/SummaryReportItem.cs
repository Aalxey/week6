using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class SummaryReportItem
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public SummaryReportItem(string customerName, string destination, string category, double price)
        {
            CustomerName = customerName;
            Destination = destination;
            Category = category;
            Price = price;
        }
    }
}
