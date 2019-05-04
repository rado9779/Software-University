using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUniada
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, double>>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                string[] splitted = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string country = splitted[0];
                string competitor = splitted[1];
                double points = double.Parse(splitted[2]);
                if (!result.ContainsKey(country))
                {
                    result.Add(country, new Dictionary<string, double>());
                    result[country].Add(competitor, points);
                }
                else if (result.ContainsKey(country))
                {
                    if (result[country].ContainsKey(competitor))
                    {
                        result[country][competitor] += points;
                    }
                    else 
                    {
                        result[country].Add(competitor, points);
                    }
                }
            }
            foreach (var country in result.OrderByDescending(x => x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key}: {country.Value.Values.Sum()}");
                foreach (var contestants in country.Value)
                {
                    Console.WriteLine($" -- {contestants.Key} -> {contestants.Value}");
                }
            }
        }
    }
}
