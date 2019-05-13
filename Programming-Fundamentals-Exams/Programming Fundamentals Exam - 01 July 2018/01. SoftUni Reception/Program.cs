using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int totalWorkPerHour = firstEmployee + secondEmployee + thirdEmployee;
            int hours = 0;

            while (studentsCount > 0)
            {
                studentsCount -= totalWorkPerHour;
                hours++;
                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");

        }
    }
}
