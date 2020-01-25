using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            string text = string.Empty;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = line[0];

                if (command == "1")
                {
                    stack.Push(text);
                    text += line[1];
                }
                else if (command == "2")
                {
                    stack.Push(text);
                    int count = int.Parse(line[1]);
                    text = text.Substring(0, text.Length - count);
                }
                else if (command == "3")
                {
                    int index = int.Parse(line[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command == "4")
                {
                    text = stack.Pop();
                }
            }
        }
    }
}
