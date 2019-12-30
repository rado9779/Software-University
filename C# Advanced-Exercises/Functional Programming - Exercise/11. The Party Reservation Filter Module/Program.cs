using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
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
            Func<string, string, bool> contains = (a, b) => a.Contains(b);
            Func<string, int, bool> length = (a, b) => a.Length == b;

            var result = new List<string>(guestList);
            var sorted = new List<string>();

            while (true)
            {
                string[] line = Console.ReadLine().Split(';');
                if (line[0] == "Print")
                {
                    break;
                }

                switch (line[1])
                {
                    case "Starts with":
                        sorted = guestList
                           .Where(p => startsWith(p, line[2]))
                           .ToList();
                        break;
                    case "Ends with":
                        sorted = guestList
                           .Where(p => endsWith(p, line[2]))
                           .ToList();
                        break;
                    case "Length":
                        sorted = guestList
                           .Where(p => length(p, int.Parse(line[2])))
                           .ToList();
                        break;
                    case "Contains":
                        sorted = guestList
                          .Where(p => contains(p, line[2]))
                          .ToList();
                        break;
                }
                switch (line[0])
                {
                    case "Add filter":
                        result
                            .RemoveAll(r => sorted.Contains(r));
                        break;
                    case "Remove filter":
                        result.AddRange(sorted);
                        result = result.Distinct().ToList();
                        break;
                }
            }

            guestList.RemoveAll(i => !result.Contains(i));
            Console.WriteLine(string.Join(" ", guestList));
        }
    }
}
