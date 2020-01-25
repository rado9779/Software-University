using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int n = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int number = 1; number <= n; number++)
            {
                bool divisible = true;

                foreach (var divider in dividers)
                {
                    if (number % divider != 0)
                    {
                        divisible = false;
                    }
                }
                if (divisible == true)
                {
                    numbers.Add(number);
                }
            }

            Action<List<int>> printNumbers = nums => Console.WriteLine(string.Join(" ",nums));
            printNumbers(numbers);


        }
    }
}
