using System;

namespace _03._Pastry_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string sweet = Console.ReadLine();
            var sweetsCount = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());

            double price = 0;
            if (day <= 15)
            {
                switch (sweet)
                {
                    case "Cake":
                        price = 24;
                        break;
                    case "Souffle":
                        price = 6.66;
                        break;
                    case "Baklava":
                        price = 12.60;
                        break;
                    default:
                        break;
                }
            }
            else if (day > 15)
            {
                switch (sweet)
                {
                    case "Cake":
                        price = 28.70;
                        break;
                    case "Souffle":
                        price = 9.80;
                        break;
                    case "Baklava":
                        price = 16.98;
                        break;
                    default:
                        break;
                }
            }

            double totalSum = sweetsCount * price;
            if (day <= 22)
            {

                if (totalSum >= 100 && totalSum <= 200)
                {
                    totalSum -= totalSum * 0.15;
                }
                else if (totalSum > 200)
                {
                    totalSum -= totalSum * 0.25;
                }
                if (day <= 15)
                {
                    totalSum -= totalSum * 0.10;
                }
            }

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
