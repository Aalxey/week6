namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            r.Length = 10;
            r.Breadth = 5;

            Console.WriteLine($"Length: {r.Length}");
            Console.WriteLine($"Breadth: {r.Breadth}");
            Console.WriteLine($"Area: {r.CalculateArea()}");
            Console.WriteLine($"Perimeter: {r.CalculatePerimeter()}");

        }
    }
}
