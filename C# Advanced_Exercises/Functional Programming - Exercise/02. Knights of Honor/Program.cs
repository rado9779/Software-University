using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printNames = name =>
                Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", name));

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(input);
        }
    }
}
