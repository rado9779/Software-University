using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsRecord = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                     .Split();

                string name = line[0];
                double grade = double.Parse(line[1]);

                if (studentsRecord.ContainsKey(name) == false)
                {
                    studentsRecord.Add(name, new List<double>());
                }

                studentsRecord[name].Add(grade);
            }

            foreach (var student in studentsRecord)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
