using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Grains_of_Sands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sands = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] line = Console.ReadLine().Split();
                string command = line[0];
                if (command == "Mort")
                {
                    break;
                }
                if (command == "Add")
                {
                    int value = int.Parse(line[1]);
                    sands.Add(value);
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(line[1]);
                    if (sands.Contains(value))
                    {
                        sands.Remove(value);
                    }
                    else if (value >= 0 && value <= sands.Count)
                    {
                        sands.RemoveAt(value);
                    }
                }
                else if (command == "Replace")
                {
                    int value = int.Parse(line[1]);
                    int replacement = int.Parse(line[2]);
                    if (sands.Contains(value))
                    {
                        int index = sands.IndexOf(value);
                        sands[index] = replacement;
                    }
                }
                else if (command == "Increase")
                {
                    int value = int.Parse(line[1]);
                    bool found = false;
                    foreach (var sand in sands)
                    {
                        if (sand >= value)
                        {
                            value = sand;
                            found = true;
                            break;
                        }
                    }

                    if (found == false)
                    {
                        value = sands.Last();
                    }
                    for (int i = 0; i < sands.Count; i++)
                    {
                        sands[i] += value;
                    }
                }
                else if (command == "Collapse")
                {
                    int value = int.Parse(line[1]);

                    sands.RemoveAll(x => x < value);
                }
            }
            Console.WriteLine(string.Join(' ', sands));

        }
    }
}
