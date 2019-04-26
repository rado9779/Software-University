using System;

namespace _03._Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string implement = Console.ReadLine();

            double difficulty = 0;
            double performance = 0;

            if (country == "Russia")
            {
                switch (implement)
                {
                    case "ribbon":
                        difficulty = 9.100;
                        performance = 9.400;
                        break;
                    case "hoop":
                        difficulty =  9.300;
                        performance = 9.800;
                        break;
                    case "rope":
                        difficulty = 9.600;
                        performance = 9.000;
                        break;
                }
            }
            else if (country == "Bulgaria")
            {
                switch (implement)
                {
                    case "ribbon":
                        difficulty = 9.600;
                        performance = 9.400;
                        break;
                    case "hoop":
                        difficulty = 9.550;
                        performance = 9.750;
                        break;
                    case "rope":
                        difficulty = 9.500;
                        performance = 9.400;
                        break;
                }
            }
            else if (country == "Italy")
            {
                switch (implement)
                {
                    case "ribbon":
                        difficulty = 9.200;
                        performance = 9.500;
                        break;
                    case "hoop":
                        difficulty = 9.450;
                        performance = 9.350;
                        break;
                    case "rope":
                        difficulty = 9.700;
                        performance = 9.150;
                        break;
                }
            }
            double totalPoints = difficulty + performance;
            Console.WriteLine($"The team of {country} get {totalPoints:f3} on {implement}.");
            double percents = ((20 - totalPoints) / 20) * 100;
            Console.WriteLine($"{percents:f2}%");
        }
    }
}
