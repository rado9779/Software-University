using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ComparingObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Person> people = new List<Person>();

            
            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split();

                if (line[0] == "END")
                {
                    break;
                }

                people.Add(new Person(line[0], int.Parse(line[1]), line[2]));
            }

            Person target = people[int.Parse(Console.ReadLine()) - 1];
            int matches = people.Count(p => p.CompareTo(target) == 0);

            if (matches <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
            }
        }
    }
}
