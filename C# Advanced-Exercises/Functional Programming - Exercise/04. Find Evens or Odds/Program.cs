using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boundaries = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lowerBound = boundaries[0];
            int upperBound = boundaries[1];

            string command = Console.ReadLine();

            List<int> numbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;

            if (command == "odd")
            {
                numbers = numbers
                     .Where(x => isOdd(x))
                     .ToList();
            }
            else if (command == "even")
            {
                numbers = numbers
                    .Where(x => isEven(x))
                    .ToList();
            }

            Action<List<int>> PrintNumbers = nums =>
            Console.WriteLine(string.Join(" ", nums));

            PrintNumbers(numbers);
        }
    }
}
