using System;

namespace _02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double guests = double.Parse(Console.ReadLine());
            double pricePerHuman = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (guests >= 10 && guests <= 15)
            {
                pricePerHuman -= pricePerHuman * 0.15;
            }
            else if (guests >= 15 && guests <= 20)
            {
                pricePerHuman -= pricePerHuman * 0.20;
            }
            else if (guests > 20)
            {
                pricePerHuman -= pricePerHuman * 0.25;
            }

            double cakePrice = budget * 0.10;
            double totalSum = (guests * pricePerHuman) + cakePrice;

            if (budget >= totalSum)
            {
                Console.WriteLine($"It is party time! {budget - totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {totalSum-budget:f2} leva needed.");
            }

        }
    }
}
