using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string setSize = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());

            double price = 0;
            int count = 0;

            if (setSize == "small")
            {
                count = 2;
                switch (fruit)
                {
                    case "Watermelon":
                        price = 56;
                        break;
                    case "Mango":
                        price = 36.66;
                        break;
                    case "Pineapple":
                        price = 42.10;
                        break;
                    case "Raspberry":
                        price = 20;
                        break;
                }
            }
            else if (setSize == "big")
            {
                count = 5;
                switch (fruit)
                {
                    case "Watermelon":
                        price = 28.70;
                        break;
                    case "Mango":
                        price = 19.60;
                        break;
                    case "Pineapple":
                        price = 24.80;
                        break;
                    case "Raspberry":
                        price = 15.20;
                        break;
                }
            }

            double totalSum = sets * (count * price);
            if (totalSum >= 400 && totalSum <= 1000)
            {
                totalSum -= totalSum * 0.15;
            }
            else if (totalSum > 1000)
            {
                totalSum -= totalSum * 0.50;
            }
            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
