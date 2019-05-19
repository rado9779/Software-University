using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            Stack<int> stack = new Stack<int>(input);

            while (true)
            {
                string commandInfo = Console.ReadLine().ToLower();
                if (commandInfo == "end")
                {
                    break;
                }
                string[] tokens = commandInfo.Split();
                string command = tokens[0].ToLower();
                if (command == "add")
                {
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        int num = int.Parse(tokens[i]);
                        stack.Push(num);
                    }
                }
                else if (command == "remove")
                {
                    int numsToRemove = int.Parse(tokens[1]);
                    if (numsToRemove > stack.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < numsToRemove; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            var sum = stack.Sum();
            Console.WriteLine("Sum: {0}", sum);
        }
    }
}
