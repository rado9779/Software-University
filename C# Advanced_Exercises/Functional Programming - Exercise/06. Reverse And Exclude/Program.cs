using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = x => x % n != 0;

            input = input
               .Reverse()
               .Where(x => isDivisible(x))
               .ToArray();

            Action<int[]> printNumbers = numbers => Console.WriteLine(string.Join(" ", numbers));

            printNumbers(input);
        }
    }
}
