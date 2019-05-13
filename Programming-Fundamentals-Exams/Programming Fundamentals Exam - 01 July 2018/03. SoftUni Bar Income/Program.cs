using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*?<(?<product>[\w]+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[\d+]*[\.]*[\d+]*)\$$";
            Regex regex = new Regex(pattern);
            double totalMoney = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of shift")
                {
                    break;
                }
                if (regex.IsMatch(line))
                {
                    Match match = regex.Match(line);
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    price *= count;
                    totalMoney += price;

                    string result = $"{customer}: {product} - {price:f2}";
                    Console.WriteLine(result);
                }
            }
            Console.WriteLine($"Total income: {totalMoney:f2}");
        }
    }
}
