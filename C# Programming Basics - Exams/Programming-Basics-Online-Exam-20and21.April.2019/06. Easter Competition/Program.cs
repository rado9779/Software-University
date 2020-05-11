using System;

namespace _06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozynaciCount = int.Parse(Console.ReadLine());

            int bestpoints = 0;
            string bestChef = "";

            for (int i = 0; i < kozynaciCount; i++)
            {
                string chef = Console.ReadLine();
                int currentPoint = 0;
                while (true)
                {
                    string rate = Console.ReadLine();
                    if (rate == "Stop")
                    {
                        break;
                    }
                    else
                    {
                        int temp = int.Parse(rate);
                        currentPoint += temp;
                    }
                }
                Console.WriteLine($"{chef} has {currentPoint} points.");
                if (currentPoint > bestpoints)
                {
                    bestpoints = currentPoint;
                    bestChef = chef;
                    Console.WriteLine($"{chef} is the new number 1!");
                }
            }
            Console.WriteLine($"{bestChef} won competition with {bestpoints} points!");
        }
    }
}
