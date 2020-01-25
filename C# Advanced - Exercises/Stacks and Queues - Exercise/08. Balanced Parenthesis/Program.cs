using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<char>();
            char[] input = Console.ReadLine().ToCharArray();

            char[] openBrackets = new char[] { '{', '[', '(' };
            bool isValid = true;

            foreach (var bracket in input)
            {
                if (openBrackets.Contains(bracket))
                {
                    stack.Push(bracket);
                    continue;
                }
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stack.Peek() == '{' && bracket == '}')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '[' && bracket == ']')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '(' && bracket == ')')
                {
                    stack.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
