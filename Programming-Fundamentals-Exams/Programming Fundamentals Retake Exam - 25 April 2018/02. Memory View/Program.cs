using System;
using System.Collections.Generic;

namespace _02._Memory_View
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            List<string> words = new List<string>();
            
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Visual Studio crash")
                {
                    break;
                }
                result += line + " ";
            }
            string[] splitted = result.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splitted.Length - 5; i++)
            {
                if (splitted[i] == "32656"
                    && splitted[i + 1] == "19759"
                    && splitted[i + 2] == "32763"
                    && splitted[i + 3] == "0"
                    && splitted[i + 5] == "0")
                {
                    string word = "";
                    int wordLenght = int.Parse(splitted[i + 4]);
                    for (int j = i + 6; j < i + 6 + wordLenght; j++)
                    {
                        word += (char)int.Parse(splitted[j]);
                    }
                    words.Add(word);
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

        }
    }
}
