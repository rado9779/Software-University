using System;

namespace _05._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            double won = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string line = Console.ReadLine();
                if (line == "W")
                {
                    totalPoints += 2000;
                    won++;
                }
                else if (line == "F")
                {
                    totalPoints += 1200;
                }
                else if (line == "SF")
                {
                    totalPoints += 720;
                }
            }
            Console.WriteLine($"Final points: {totalPoints + initialPoints}");
            double avgPoints = totalPoints / tournaments;
            Console.WriteLine($"Average points: {Math.Floor(avgPoints)}");
            double percentsOfWin = (won / tournaments) * 100;
            Console.WriteLine($"{percentsOfWin:f2}%");

        }
    }
}
