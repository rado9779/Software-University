using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            int capacity = int.Parse(Console.ReadLine());
            var stack = new Stack<int>(clothes);
            int racks = 1;
            int sum = 0;

            while (stack.Count > 0)
            {
                int item = stack.Peek();
                if (item + sum <= capacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    sum = stack.Pop();
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
