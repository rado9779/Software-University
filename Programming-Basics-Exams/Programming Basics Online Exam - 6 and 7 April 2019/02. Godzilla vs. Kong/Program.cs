using System;

namespace _02._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            double statistics = double.Parse(Console.ReadLine());
            double pricePerStatistic = double.Parse(Console.ReadLine());

            double decor = filmBudget / 10;
            if (statistics > 150)
            {
                pricePerStatistic -= (pricePerStatistic * 0.10);
            }

            double totalSum = decor + (statistics * pricePerStatistic);

            if (filmBudget - totalSum >= 0)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalSum - filmBudget:f2} leva more.");
            }



        }
    }
}
