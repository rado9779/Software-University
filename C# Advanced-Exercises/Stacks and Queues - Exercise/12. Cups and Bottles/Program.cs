using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputCups = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var inputBottles = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var cups = new Queue<int>(inputCups);
            var bottles = new Stack<int>(inputBottles);
            int wasted = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentCup = cups.Peek();
                int currentBottle = bottles.Peek();



                if (currentBottle - currentCup >= 0)
                {
                    wasted += bottles.Peek() - cups.Peek();
                    bottles.Pop();
                    cups.Dequeue();
                }
                else
                {
                    while (true)
                    {
                        if (currentCup - currentBottle <= 0)
                        {
                            wasted += currentBottle - currentCup;
                            bottles.Pop();
                            cups.Dequeue();
                            break;
                        }
                        else
                        {
                            currentCup -= currentBottle;
                            bottles.Pop();
                            currentBottle = bottles.Peek();
                        }
                    }
                }
            }
            if (cups.Count <= 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(' ', cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wasted}");
        }
    }
}
