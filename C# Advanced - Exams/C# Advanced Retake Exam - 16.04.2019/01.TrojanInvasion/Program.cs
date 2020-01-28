using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            List<int> plates = new List<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> warriors = new Stack<int>();

            for (int wave = 1; wave <= waves; wave++)
            {
                warriors = new Stack<int>(Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse));

                if (wave % 3 == 0)
                {
                    int plate = int.Parse(Console.ReadLine());
                    plates.Add(plate);
                }

                while (warriors.Count > 0 && plates.Count > 0)
                {
                    int warrior = warriors.Pop();
                    int plate = plates[0];

                    if (warrior > plate)
                    {
                        warriors.Push(warrior - plate);
                        plates.RemoveAt(0);
                    }
                    else if (plate > warrior)
                    {
                        plate -= warrior;
                        plates[0] = plate;
                    }
                    else
                    {
                        plates.RemoveAt(0);
                    }
                }
                if (plates.Count == 0)
                {
                    break;
                }
            }

            if (plates.Count > 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            if (warriors.Count > 0)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine($"Warriors left: {string.Join(", ", warriors)}");
            }
        }
    }
}
