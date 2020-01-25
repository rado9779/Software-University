using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> wordLength = word => word.Length <= n;

            input = input
                .Where(x => wordLength(x))
                .ToArray();

            Action<string[]> printNames = names => Console.WriteLine(string.Join(Environment.NewLine,names));

            printNames(input);
        }
    }
}
