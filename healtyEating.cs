namespace HealthyEating;
class Program
{
    static void Main(string[] args)
    {
        double pearsPrice = double.Parse(Console.ReadLine());
        double applePrice = pearsPrice * 0.5;
        double orangesPrice = applePrice * 0.8;
        double bananasPrice = pearsPrice * 0.25;

        double bananas = double.Parse(Console.ReadLine());
        double oranges = double.Parse(Console.ReadLine());
        double apples = double.Parse(Console.ReadLine());
        double pears = double.Parse(Console.ReadLine());

        double priceOfPears = pearsPrice * pears;
        double priceOfApples = applePrice * apples;
        double priceOfOranges = orangesPrice * oranges;
        double priceOfBananas = bananasPrice * bananas;

        double finalPrice = (priceOfPears + priceOfApples + priceOfOranges + priceOfBananas);
        Console.WriteLine($"{finalPrice:f2}");

    }
}
