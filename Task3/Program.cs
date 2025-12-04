namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 12, 7, 18, 3, 20 };

            Console.WriteLine("Even Numbers:");
            ProcessNumbers(numbers, n => n % 2 == 0);

            Console.WriteLine("\nNumbers Greater Than 10:");
            ProcessNumbers(numbers, n => n > 10);

            static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
            {
                foreach (int n in numbers)
                {
                    if (condition(n))
                    {
                        Console.WriteLine(n);
                    }
                }
            }
        }
    }
}
