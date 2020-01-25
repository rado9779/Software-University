using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations_ions
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

            var queue = new Queue<int>();
            //N
            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            //S
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
                if (queue.Count <= 0)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            //X
            if (queue.Contains(X))
            {
                Console.WriteLine("true");
                return;
            }
            int min = queue.Dequeue();
            while (queue.Count > 0)
            {
                int i = queue.Dequeue();
                if (i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine(min);
        }
    }
}
