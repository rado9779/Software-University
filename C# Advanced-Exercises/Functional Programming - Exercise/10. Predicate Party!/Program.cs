using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            var guestList = Console.ReadLine()
                .Split()
                .ToList();

            Func<string, string, bool> startsWith = (a, b) => a.StartsWith(b);
            Func<string, string, bool> endsWith = (a, b) => a.EndsWith(b);
            Func<string, int, bool> length = (a, b) => a.Length == b;

            Func<List<string>, List<string>, List<string>> doublePeople = (a, b) =>
            {
                foreach (string twice in b)
                {
                    for (int i = 0; i < a.Count * 2; i++)
                    {
                        if (i < a.Count)
                        {
                            if (a[i] == twice)
                            {
                                a.Insert(i, twice);
                                i++;
                            }
                        }
                    }
                }

                return a;
            };

            var sorted = new List<string>();



            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == "Party!")
                {
                    break;
                }

                switch (line[1])
                {
                    case "StartsWith":
                        sorted = guestList
                            .Where(p => startsWith(p, line[2]))
                            .Distinct()
                            .ToList();
                        break;
                    case "EndsWith":
                        sorted = guestList
                            .Where(p => endsWith(p, line[2]))
                            .Distinct()
                            .ToList();
                        break;
                    case "Length":
                        sorted = guestList
                            .Where(p => length(p, int.Parse(line[2])))
                            .Distinct()
                            .ToList();
                        break;
                }

                switch (line[0])
                {
                    case "Remove":
                        guestList = guestList
                            .Where(p => !sorted.Contains(p))
                            .ToList();
                        break;
                    case "Double":
                        guestList = doublePeople(guestList, sorted);
                        break;
                }
            }

            if (guestList.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", guestList)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
