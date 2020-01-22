using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            Queue<int> females = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            int matches = 0;


            while (females.Count > 0 && males.Count > 0)
            {
                //Check Male
                if (males.Peek() <= 0)
                {
                    males.Pop();
                    continue;
                }
                if (males.Peek() % 25 == 0)
                {
                    males.Pop();
                    males.Pop();
                    continue;
                }
                //Check Female
                if (females.Peek() <= 0)
                {
                    females.Dequeue();
                    continue;
                }
                if (females.Peek() % 25 == 0)
                {
                    females.Dequeue();
                    females.Dequeue();
                    continue;
                }
                //Check Match
                if (males.Peek() == females.Peek())
                {
                    males.Pop();
                    females.Dequeue();
                    matches++;
                }
                else
                {
                    females.Dequeue();
                    males.Push(males.Pop() - 2);
                }
            }

            Console.WriteLine($"Matches: {matches}");

            if (males.Count > 0)
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (females.Count > 0)
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
