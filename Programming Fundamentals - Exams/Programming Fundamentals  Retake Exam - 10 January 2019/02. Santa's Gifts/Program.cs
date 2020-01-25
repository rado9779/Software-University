using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine().Split().Select(int.Parse).ToList();
            int currentPosition = 0;

            for (int i = 0; i < commands; i++)
            {
                string[] line = Console.ReadLine().Split();
                string command = line[0];
                if (command == "Forward")
                {
                    int steps = int.Parse(line[1]);
                    if (steps < 0 || currentPosition + steps >= houses.Count)
                    {
                        continue;
                    }
                    currentPosition += steps;
                    houses.RemoveAt(currentPosition);
                }
                else if (command == "Back")
                {
                    int steps = int.Parse(line[1]);
                    if (steps < 0 || currentPosition - steps < 0)
                    {
                        continue;
                    }
                    currentPosition -= steps;
                    houses.RemoveAt(currentPosition);
                }
                else if (command == "Gift")
                {
                    int index = int.Parse(line[1]);
                    int houseNumber = int.Parse(line[2]);
                    if (index < 0 || index >= houses.Count)
                    {
                        continue;
                    }
                    houses.Insert(index, houseNumber);
                    currentPosition = index;
                }
                else if (command == "Swap")
                {
                    int firstHouse = int.Parse(line[1]);
                    int secondHouse = int.Parse(line[2]);

                    if (houses.Contains(firstHouse) && houses.Contains(secondHouse))
                    {
                        int firstIndex = houses.IndexOf(firstHouse);
                        int secondIndex = houses.IndexOf(secondHouse);

                        houses[firstIndex] = secondHouse;
                        houses[secondIndex] = firstHouse;
                    }
                }
            }
            Console.WriteLine($"Position: {currentPosition}");
            Console.WriteLine(string.Join(", ", houses));

        }
    }
}
