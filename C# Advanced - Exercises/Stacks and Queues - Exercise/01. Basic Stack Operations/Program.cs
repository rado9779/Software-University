using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int N = input[0];
            int S = input[1];
            int X = input[2];

            int[] numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();
            //N
            for (int i = 0; i < N; i++)
            {
                stack.Push(numbers[i]);
            }
            //S
            for (int i = 0; i < S; i++)
            {
                stack.Pop();
                if (stack.Count <= 0)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            //X
            foreach (var key in stack)
            {
                if (key == X)
                {
                    Console.WriteLine("true");
                    return;
                }
            }
            int minNum = stack.Pop();
            while (stack.Count > 0)
            {
                if (stack.Pop() < minNum)
                {
                    minNum = stack.Pop();
                }
            }
            Console.WriteLine(minNum);

        }
    }
}
