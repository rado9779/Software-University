using System;

namespace _02._Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var lenght = double.Parse(Console.ReadLine());
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var pricePerTile = double.Parse(Console.ReadLine());
            var workmanSum = double.Parse(Console.ReadLine());

            double area = width * lenght;
            double tileArea = (side * height) / 2;
            double tileSum = Math.Ceiling((area / tileArea) + 5);
            double totalSum = (tileSum * pricePerTile) + workmanSum;

            if (budget >= totalSum)
            {
                Console.WriteLine($"{budget-totalSum:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {totalSum - budget:f2} lv more.");
            }


        }
    }
}
