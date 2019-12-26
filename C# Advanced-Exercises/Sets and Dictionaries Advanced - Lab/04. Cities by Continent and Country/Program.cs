using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> result =
                new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = line[0];
                string country = line[1];
                string city = line[2];

                if (result.ContainsKey(continent) == false)
                {
                    result.Add(continent, new Dictionary<string, List<string>>());
                }
                if (result[continent].ContainsKey(country) == false)
                {
                    result[continent].Add(country,new List<string>());
                }

                result[continent][country].Add(city);
            }

            foreach (var continent in result)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
