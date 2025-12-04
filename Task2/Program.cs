namespace Task2
{
    public delegate double DiscountStrategy(double price);

    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 1000;
            PriceCalculator calculator = new PriceCalculator();

            Console.WriteLine("Festival Discount: " +
                              calculator.CalculateFinalPrice(price, DiscountStrategies.FestivalDiscount));

            Console.WriteLine("Seasonal Discount: " +
                              calculator.CalculateFinalPrice(price, DiscountStrategies.SeasonalDiscount));

            Console.WriteLine("No Discount: " +
                              calculator.CalculateFinalPrice(price, DiscountStrategies.NoDiscount));

            Console.WriteLine("30% Lambda Discount: " +
                              calculator.CalculateFinalPrice(price, p => p * 0.70));
        }
    }
}