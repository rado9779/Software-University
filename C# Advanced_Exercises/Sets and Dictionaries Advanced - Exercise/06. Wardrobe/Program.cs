using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string colour = line[0];

                if (wardrobe.ContainsKey(colour) == false)
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                string[] clothes = line[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < clothes.Length; j++)
                {
                    string item = clothes[j];

                    if (wardrobe[colour].ContainsKey(item) == false)
                    {
                        wardrobe[colour].Add(item, 0);
                    }

                    wardrobe[colour][item]++;
                }
            }

            string[] toFind = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string searchedItemColor = toFind[0];
            string searchedItem = toFind[1];

            foreach (var (colour, clothes) in wardrobe)
            {
                Console.WriteLine($"{colour} clothes:");
                foreach (var (item, count) in clothes)
                {
                    if (colour == searchedItemColor && item == searchedItem)
                    {
                        Console.WriteLine($"* {item} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item} - {count}");
                    }
                }
            }
        }
    }
}
