using System;

namespace _02._Christmas_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double fantasyCount = double.Parse(Console.ReadLine());
            double horrorCount = double.Parse(Console.ReadLine());
            double romanticCount = double.Parse(Console.ReadLine());

            double fantasyPrice = 14.90 * fantasyCount;
            double horrorPrice = 9.80 * horrorCount;
            double romanticPrice = 4.30 * romanticCount;

            double totalSum = fantasyPrice + horrorPrice + romanticPrice;
            totalSum -= totalSum * 0.20;

            if (totalSum >= money)
            {
                double diff = totalSum - money;
                double diffPercent = Math.Floor(diff * 0.10);
                money += diff - diffPercent;
                Console.WriteLine($"{money:f2} leva donated.");
                Console.WriteLine($"Sellers will receive {diffPercent} leva.");
            }
            else
            {
                money -= totalSum;
                Console.WriteLine($"{money:f2} money needed.");
            }

        }
    }
}
