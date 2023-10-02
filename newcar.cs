namespace ExamPrep;
class Program
{
    static void Main(string[] args)
    {
        int ethereum = int.Parse(Console.ReadLine());
        double bgLv = double.Parse(Console.ReadLine());
        double comision = double.Parse(Console.ReadLine());

        int ethereumLv = ethereum * 1168;
        double allLv = ethereumLv + bgLv;
        double euro = allLv / 1.95;
        double comisionEuro = euro * (comision / 100);
        double euroLeft = euro - comisionEuro;
        Console.WriteLine($"{euroLeft:f2}");
    }
}