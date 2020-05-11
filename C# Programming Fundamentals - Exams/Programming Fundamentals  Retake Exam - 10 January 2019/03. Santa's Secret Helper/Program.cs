using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Santa_sSecretHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            List<string> result = new List<string>();

            while (true)
            {
                string code = Console.ReadLine();
                if (code == "end")
                {
                    break;
                }
                string decreased = "";
                for (int i = 0; i < code.Length; i++)
                {
                    int symbol = code[i] - key;
                    decreased += (char)symbol;
                }
                string pattern = @"@(?<name>[A-Za-z]+)[^-@!:>]*!(?<behavior>(G))!";
                Match matched = Regex.Match(decreased,pattern);
                string name = "";

                if (matched.Success)
                {
                    name = matched.Groups["name"].Value;
                    result.Add(name);
                }
            }
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
