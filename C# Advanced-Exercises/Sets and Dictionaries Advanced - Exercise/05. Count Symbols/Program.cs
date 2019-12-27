using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (result.ContainsKey(symbol) == false)
                {
                    result.Add(symbol, 0);
                }

                result[symbol]++;
            }

            foreach (var (symbol, count) in result.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{symbol}: {count} time/s");
            }
        }
    }
}
