using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class DiscountStrategies
    {
        public static double FestivalDiscount(double price)
        {
            return price * 0.80; 
        }

        public static double SeasonalDiscount(double price)
        {
            return price * 0.90;
        }

        public static double NoDiscount(double price)
        {
            return price;         
        }

    }
}
