using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> leftSocks = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> rightSocks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            List<int> result = new List<int>();

            while (rightSocks.Count != 0 && leftSocks.Count != 0)
            {
                int left = leftSocks.Pop();
                int right = rightSocks.Peek();

                if (left > right)
                {
                    int toAdd = left + right;
                    result.Add(toAdd);
                    rightSocks.Dequeue();
                }
                else if (right == left)
                {
                    rightSocks.Dequeue();
                    leftSocks.Push(left + 1);
                }
            }

            Console.WriteLine(result.Max());
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
