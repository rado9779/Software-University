using System;

namespace _05._Project_Prize
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double prize = double.Parse(Console.ReadLine());
            int totalPoints = 0;
            
            for (int i = 1; i <= parts; i++)
            {
                int currentPoints = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    currentPoints *= 2;
                }
                totalPoints += currentPoints;
            }

            double totalSum = prize * totalPoints;
            Console.WriteLine($"The project prize was {totalSum:f2} lv.");
        }
    }
}
