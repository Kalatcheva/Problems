namespace ExamPrep;
class Program
{
    static void Main(string[] args)
    {
        int people = int.Parse(Console.ReadLine());
        double tax = double.Parse(Console.ReadLine());
        double bedPrice = double.Parse(Console.ReadLine());
        double umbrellaPrice = double.Parse(Console.ReadLine());

        double neededUmbrellas = people / 2;
        double neededBeds = people * 0.8;

        double umbrellaCost = neededUmbrellas * umbrellaPrice;
        double bedCost = neededBeds * bedPrice;
        double allTaxes = people * tax;

        double allCosts = umbrellaCost + bedCost + allTaxes;
        Console.WriteLine($"Total cost: {allCosts:f2} lv.");
    }
}