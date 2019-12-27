using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int n = nm[0];
            int m = nm[1];

            List<int> nElements = new List<int>();
            List<int> mElements = new List<int>();

            HashSet<int> unique = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                nElements.Add(element);
            }

            for (int i = 0; i < m; i++)
            {
                int element = int.Parse(Console.ReadLine());
                mElements.Add(element);
            }

            foreach (var nElement in nElements)
            {
                foreach (var mElement in mElements)
                {
                    if (nElement == mElement)
                    {
                        unique.Add(nElement);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", unique));

        }
    }
}
