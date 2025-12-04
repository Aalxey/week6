using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal static class NumberOperations
    {
        public static IEnumerable<int> SquareNumbers(List<int> numbers)
        {
            return numbers.Select(n => n * n);
        }
    }
}
