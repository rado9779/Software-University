using System;

namespace _05._Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double between2to3 = 0;
            double between3to4 = 0;
            double between4to5 = 0;
            double over5 = 0;
            double total = 0;


            for (int i = 0; i < students; i++)
            {
                double rating = double.Parse(Console.ReadLine());
                total += rating;

                if (rating >= 2.00 && rating <= 2.99)
                {
                    between2to3++;
                }
                else if (rating >= 3.00 && rating <= 3.99)
                {
                    between3to4++;
                }
                else if (rating >= 4.00 && rating <= 4.99)
                {
                    between4to5++;
                }
                else if (rating >= 5.00 && rating <= 6.00)
                {
                    over5++;
                }
            }

            double topStudentsPercent = (over5 / students) * 100;
            Console.WriteLine($"Top students: {topStudentsPercent:f2}%");
            double fourToFive = (between4to5 / students) * 100;
            Console.WriteLine($"Between 4.00 and 4.99: {fourToFive:f2}%");
            double threeToFour = (between3to4 / students) * 100;
            Console.WriteLine($"Between 3.00 and 3.99: {threeToFour:f2}%");
            double failed = (between2to3 / students) * 100;
            Console.WriteLine($"Fail: {failed:f2}%");
            double average = total / students;
            Console.WriteLine($"Average: {average:f2}");

        }
    }
}
