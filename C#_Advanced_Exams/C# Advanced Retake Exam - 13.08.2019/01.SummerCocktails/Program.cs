using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SummerCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cocktails = new Dictionary<string, int>()
            {
                {"Mimosa",150},
                {"Daiquiri",250},
                {"Sunshine",300},
                {"Mojito",400}
            };

            Dictionary<string, int> readyCocktails = new Dictionary<string, int>();

            Queue<int> ingredientValues = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> freshnessLevels = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while (ingredientValues.Count > 0 && freshnessLevels.Count > 0)
            {
                int ingredient = ingredientValues.Peek();

                if (ingredient == 0)
                {
                    ingredientValues.Dequeue();
                    continue;
                }

                int freshnessLevel = freshnessLevels.Peek();

                int mixed = ingredient * freshnessLevel;

                if (cocktails.ContainsValue(mixed))
                {
                    string cocktailName = cocktails.FirstOrDefault(x => x.Value == mixed).Key;

                    if (readyCocktails.ContainsKey(cocktailName) == false)
                    {
                        readyCocktails.Add(cocktailName, 0);
                    }
                    readyCocktails[cocktailName]++;

                    ingredientValues.Dequeue();
                    freshnessLevels.Pop();
                }
                else
                {
                    freshnessLevels.Pop();
                    int ingredientValue = ingredientValues.Dequeue();
                    ingredientValues.Enqueue(ingredientValue + 5);
                }
            }
            Console.WriteLine(HaveAllTypesCocktails(readyCocktails));
            if (ingredientValues.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingredientValues.Sum()}");
            }
            foreach (var cocktail in readyCocktails.OrderBy(x => x.Key))
            {
                Console.WriteLine($"# {cocktail.Key} --> {cocktail.Value}");
            }
        }
        public static string HaveAllTypesCocktails(Dictionary<string, int> cocktails)
        {
            if (cocktails.ContainsKey("Mimosa") && cocktails.ContainsKey("Daiquiri") &&
                cocktails.ContainsKey("Sunshine") && cocktails.ContainsKey("Mojito"))
            {
                return "It's party time! The cocktails are ready!";
            }
            return "What a pity! You didn't manage to prepare all cocktails.";
        }
    }
}
