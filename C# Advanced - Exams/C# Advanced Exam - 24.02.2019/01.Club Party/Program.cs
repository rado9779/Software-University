using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallsCapacity = int.Parse(Console.ReadLine());

            Stack<string> line = new Stack<string>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries));

            List<string> halls = new List<string>();
            List<int> reservations = new List<int>();

            int currentPeople = 0;

            while (line.Count > 0)
            {
                string element = line.Pop();

                if (char.IsLetter(element[0]))
                {
                    halls.Add(element);
                }
                else
                {
                    int guests = int.Parse(element);

                    if (halls.Count == 0)
                    {
                        continue;
                    }
                    if (currentPeople + guests > hallsCapacity)
                    {
                        Console.WriteLine($"{halls[0]} -> {string.Join(", ", reservations)}");
                        halls.RemoveAt(0);
                        reservations.Clear();
                        currentPeople = 0;
                    }
                    if (halls.Count > 0)
                    {
                        reservations.Add(guests);
                        currentPeople += guests;
                    }
                }
            }
        }
    }
}
