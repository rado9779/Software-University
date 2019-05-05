using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Santa_s_New_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = new Dictionary<string, int>();
            var presents = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                string[] splitted = line.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                if (splitted[0] == "Remove")
                {
                    string name = splitted[1];
                    if (children.ContainsKey(name))
                    {
                        children.Remove(name);
                    }
                    continue;
                }
                string child = splitted[0];
                string present = splitted[1];
                int amount = int.Parse(splitted[2]);

                if (!children.ContainsKey(child))
                {
                    children.Add(child, amount);
                }
                else
                {
                    children[child] += amount;
                }
                if (!presents.ContainsKey(present))
                {
                    presents.Add(present, amount);
                }
                else
                {
                    presents[present] += amount;
                }
            }

            Console.WriteLine("Children:");
            foreach (var kvp in children.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
            Console.WriteLine("Presents:");
            foreach (var kvp in presents)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
