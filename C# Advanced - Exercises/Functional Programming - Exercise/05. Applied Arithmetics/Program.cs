using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int> increaseByOne = number => number + 1;
            Func<int, int> multiplyByTwo = number => number * 2;
            Func<int, int> subtractByOne = number => number - 1;

            Action<int[]> printNumbers = numbers => Console.WriteLine(string.Join(" ",inputNumbers));
            

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    inputNumbers = inputNumbers.Select(increaseByOne).ToArray();
                }
                else if (command == "multiply")
                {
                    inputNumbers = inputNumbers.Select(multiplyByTwo).ToArray();
                }
                else if (command == "subtract")
                {
                    inputNumbers = inputNumbers.Select(subtractByOne).ToArray();
                }
                else if (command == "print")
                {
                    printNumbers(inputNumbers);
                }
            }
        }
    }
}
