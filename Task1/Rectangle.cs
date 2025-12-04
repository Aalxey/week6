using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Rectangle
    {
        private double length;
        private double breadth;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        public double CalculateArea() => length * breadth;

        public double CalculatePerimeter() => 2 * (length + breadth);

    }
}
