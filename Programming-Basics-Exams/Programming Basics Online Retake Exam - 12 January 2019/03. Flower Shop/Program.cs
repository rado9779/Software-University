using System;

namespace _03._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var chrysanthemums = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isHoliday = Console.ReadLine();

            double chrysanthemumsSum = 0;
            double rosesSum = 0;
            double tulipsSum = 0;

            if (season == "Spring" || season == "Summer")
            {
                chrysanthemumsSum = chrysanthemums * 2;
                rosesSum = roses * 4.10;
                tulipsSum = tulips * 2.50;
                
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrysanthemumsSum = chrysanthemums * 3.75;
                rosesSum = roses * 4.50;
                tulipsSum = tulips * 4.15;
            }

            double totalSum = chrysanthemumsSum + rosesSum + tulipsSum;
            if (isHoliday == "Y")
            {
                totalSum += totalSum * 0.15;
            }
            if (season == "Spring" && tulips > 7 )
            {
                totalSum -= totalSum * 0.05;
            }
            if (season == "Winter" && roses >= 10)
            {
                totalSum -= totalSum * 0.10;
            }
            if (chrysanthemums + roses + tulips > 20)
            {
                totalSum -= totalSum * 0.20;
            }

            Console.WriteLine($"{totalSum + 2:f2}");
        }
    }
}
