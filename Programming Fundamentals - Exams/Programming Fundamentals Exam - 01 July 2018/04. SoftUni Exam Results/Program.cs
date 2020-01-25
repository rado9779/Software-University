using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new Dictionary<string, int>();
            var languages = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "exam finished")
                {
                    break;
                }
                string[] splitted = line.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                string username = splitted[0];
                string language = splitted[1];

                if (language == "banned")
                {
                    if (students.ContainsKey(username))
                    {
                        students.Remove(username);
                    }
                }
                else
                {
                    int points = int.Parse(splitted[2]);
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, points);
                    }
                    else if (students.ContainsKey(username))
                    {
                        if (students[username] < points)
                        {
                            students[username] = points;
                        }
                    }
                    if (!languages.ContainsKey(language))
                    {
                        languages.Add(language, 1);
                    }
                    else
                    {
                        languages[language]++;
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var kvp in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var kvp in languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
