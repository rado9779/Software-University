using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[],int> minValueFunction = numbers =>
            {
                int minValue = int.MaxValue;

                foreach (var number in input)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }

                return minValue;
            };

            Console.WriteLine(minValueFunction(input));
        }
    }
}
