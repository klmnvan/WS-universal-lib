using WSUniversalLib;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            Console.WriteLine(calculation.GetQuantityForProduct(3, 1, 15, 20, 45));
        }
    }
}
