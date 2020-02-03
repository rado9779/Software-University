using System;
using System.Collections.Generic;

namespace P03_StudentSystem
{
    class StartUp
    {
        static void Main()
        {

           Dictionary<string, Student> repository = new Dictionary<string, Student>();

            while (true)
            {
                string[] line = Console.ReadLine().Split();

                if (line[0] == "Create")
                {
                    var name = line[1];
                    var age = int.Parse(line[2]);
                    var grade = double.Parse(line[3]);
                    if (!repository.ContainsKey(name))
                    {
                        var student = new Student(name, age, grade);
                        repository[name] = student;
                    }
                }
                else if (line[0] == "Show")
                {
                    var name = line[1];
                    if (repository.ContainsKey(name))
                    {
                        var student = repository[name];
                        string view = $"{student.Name} is {student.Age} years old.";

                        if (student.grade >= 5.00)
                        {
                            view += " Excellent student.";
                        }
                        else if (student.grade < 5.00 && student.grade >= 3.50)
                        {
                            view += " Average student.";
                        }
                        else
                        {
                            view += " Very nice person.";
                        }

                        Console.WriteLine(view);
                    }

                }
                else if (line[0] == "Exit")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
