using System;

namespace _01._Bonus_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int intialBonus = int.Parse(Console.ReadLine()) + 5;

            double maxBonusPoints = 0;
            double maxStudentAttendance = 0;

            for (int i = 1; i <= studentsCount; i++)
            {
                double attendance = double.Parse(Console.ReadLine());
                double currentBonus = attendance / lecturesCount *  intialBonus;

                if (currentBonus > maxBonusPoints)
                {
                    maxBonusPoints = currentBonus;
                    maxStudentAttendance = attendance;
                }
            }

            Console.WriteLine("The maximum bonus score for this course is {0}.The student has attended {1} lectures.",
                Math.Ceiling(maxBonusPoints),maxStudentAttendance);
        }
    }
}
