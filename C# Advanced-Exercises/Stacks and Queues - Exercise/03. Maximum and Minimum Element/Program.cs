using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] queue = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = queue[0];

                if (command == 1)
                {
                    stack.Push(queue[1]);
                }
                if (command == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                if (command == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                if (command == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            if (stack.Count > 0)
            {
                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}
