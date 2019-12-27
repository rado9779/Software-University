using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfElements = int.Parse(Console.ReadLine());

            SortedSet<string> chemicalELements = new SortedSet<string>();

            for (int i = 0; i < numOfElements; i++)
            {
                string[] inputElements = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                for (int j = 0; j < inputElements.Length; j++)
                {
                    chemicalELements.Add(inputElements[j]);
                }
            }

            Console.WriteLine(string.Join(" ",chemicalELements));
        }
    }
}
