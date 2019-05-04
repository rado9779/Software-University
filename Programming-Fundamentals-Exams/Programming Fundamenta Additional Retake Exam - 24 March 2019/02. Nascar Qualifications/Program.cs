using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Nascar_Qualifications
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> racers = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] line = Console.ReadLine().Split();
                string command = line[0];
                if (command == "end")
                {
                    break;
                }
                else if (command == "Race")
                {
                    string racer = line[1];
                    if (!racers.Contains(racer))
                    {
                        racers.Add(racer);
                    }
                }
                else if (command == "Accident")
                {
                    string racer = line[1];

                    if (racers.Contains(racer))
                    {
                        racers.Remove(racer);
                    }
                }
                else if (command == "Box")
                {
                    string racer = line[1];

                    if (racers.Contains(racer))
                    {
                        int index = racers.IndexOf(racer);
                        if (index != racers.Count - 1)
                        {
                            racers.RemoveAt(index);
                            //
                            racers.Insert(index + 1, racer);
                        }
                    }
                }
                else if (command == "Overtake")
                {
                    string racer = line[1];

                    int counts = int.Parse(line[2]);
                    if (racers.Contains(racer))
                    {
                        int index = racers.IndexOf(racer);
                        int newIndex = index - counts;
                        if (newIndex >= 0 && newIndex < racers.Count)
                        {
                            racers.RemoveAt(index);
                            racers.Insert(newIndex, racer);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ~ ", racers));
        }
    }
}
