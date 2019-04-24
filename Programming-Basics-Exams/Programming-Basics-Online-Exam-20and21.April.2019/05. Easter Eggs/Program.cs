using System;

namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int redCount = 0;
            int orangeCount = 0;
            int blueCount = 0;
            int greenCount = 0;

            int max = 0;
            string maxColor = "";

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                if (line == "orange")
                {
                    orangeCount++;
                    if (orangeCount > max)
                    {
                        max = orangeCount;
                        maxColor = "orange";
                    }
                }
                else if (line == "red")
                {
                    redCount++;
                    if (redCount > max)
                    {
                        max = redCount;
                        maxColor = "red";
                    }
                }
                else if (line == "blue")
                {
                    blueCount++;
                    if (blueCount > max)
                    {
                        max = blueCount;
                        maxColor = "blue";
                    }
                }
                else if (line == "green")
                {
                    greenCount++;
                    if (greenCount > max)
                    {
                        max = greenCount;
                        maxColor = "green";
                    }
                }
            }
            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");
            Console.WriteLine($"Max eggs: {max} -> {maxColor}");
        }
    }
}
