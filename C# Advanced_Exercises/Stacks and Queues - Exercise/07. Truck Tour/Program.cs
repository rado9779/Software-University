using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var petrolPumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] petrolPump = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                petrolPumps.Enqueue(petrolPump);
            }

            int index = 0;
            while (true)
            {
                int totalFuel = 0;
                foreach (var pump in petrolPumps)
                {
                    int amountOfPetrol = pump[0];
                    int distance = pump[1];

                    totalFuel += amountOfPetrol - distance;
                    if (totalFuel < 0)
                    {
                        index++;
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        break;
                    }
                }
                if (totalFuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(index);
        }
    }
}
