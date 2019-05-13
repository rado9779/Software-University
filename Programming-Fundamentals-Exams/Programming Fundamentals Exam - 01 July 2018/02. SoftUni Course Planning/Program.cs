using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> course = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] line = Console.ReadLine().Split(':');
                string command = line[0];
                if (command == "course start")
                {
                    for (int i = 0; i < course.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}.{course[i]}");
                    }
                    break;
                }
                else if (command == "Add")
                {
                    string lesson = line[1];
                    if (!course.Contains(lesson))
                    {
                        course.Add(lesson);
                    }
                }
                else if (command == "Insert")
                {
                    string lesson = line[1];
                    int index = int.Parse(line[2]);
                    if (!course.Contains(lesson) && index >= 0 && index < course.Count)
                    {
                        course.Insert(index, lesson);
                    }
                }
                else if (command == "Remove")
                {
                    string lesson = line[1];
                    if (course.Contains(lesson))
                    {
                        course.Remove(lesson);
                        string toRemove = lesson + "-Exercise";
                        if (course.Contains(toRemove))
                        {
                            course.Remove(toRemove);
                        }
                    }
                }
                else if (command == "Swap")
                {
                    string firstLesson = line[1];
                    string secondLesson = line[2];
                    if (course.Contains(firstLesson) && course.Contains(secondLesson))
                    {

                        int firstIndex = course.IndexOf(firstLesson);
                        int secondIndex = course.IndexOf(secondLesson);

                        course[firstIndex] = secondLesson;
                        course[secondIndex] = firstLesson;

                        string firstExercise = firstLesson + "-Exercise";
                        string secondExercise = secondLesson + "-Exercise";

                        if (course.Contains(firstExercise) && course.Contains(secondExercise))
                        {
                            course[firstIndex + 1] = secondExercise;
                            course[secondIndex + 1] = firstExercise;
                        }
                        else if (course.Contains(firstExercise) && !course.Contains(secondExercise))
                        {
                            if (secondIndex == course.Count - 1)
                            {
                                course.Add(firstExercise);
                            }
                            else
                            {
                                course.Insert(secondIndex, firstExercise);
                                course.RemoveAt(firstIndex + 1);
                            }
                        }
                        else if (!course.Contains(firstExercise) && course.Contains(secondExercise))
                        {
                            course.Insert(firstIndex + 1, secondExercise);
                            course.RemoveAt(secondIndex + 2);
                        }

                    }
                }
                else if (command == "Exercise")
                {
                    string lesson = line[1];
                    string toAdd = lesson + "-Exercise";

                    if(!course.Contains(lesson))
                    {
                        course.Add(lesson);
                        course.Add(toAdd);
                    }
                    else if(course.Contains(lesson) && !course.Contains(toAdd))
                    {
                        int index = course.IndexOf(lesson);
                        course.Insert(index + 1, toAdd);
                    }
                }
            }

        }
    }
}
