using System;

namespace _03.EasterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            int price = 0;

            if (country == "France")
            {
                switch (dates)
                {
                    case "21-23":
                        price = 30;
                            break;
                    case "24-27":
                        price = 35;
                        break;
                    case "28-31":
                        price = 40;
                        break;
                    default:
                        break;
                }
            }
            else if (country == "Italy")
            {
                switch (dates)
                {
                    case "21-23":
                        price = 28;
                        break;
                    case "24-27":
                        price = 32;
                        break;
                    case "28-31":
                        price = 39;
                        break;
                    default:
                        break;
                }
            }
            else if (country == "Germany")
            {
                switch (dates)
                {
                    case "21-23":
                        price = 32;
                        break;
                    case "24-27":
                        price = 37;
                        break;
                    case "28-31":
                        price = 43;
                        break;
                    default:
                        break;
                }
            }
            double totalSum = nights * price;
            Console.WriteLine($"Easter trip to {country} : {totalSum:f2} leva.");
        }
    }
}
