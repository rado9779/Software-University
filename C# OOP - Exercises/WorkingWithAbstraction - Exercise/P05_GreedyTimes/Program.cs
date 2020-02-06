using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class Potato
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long gems = 0;
            long money = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long count = long.Parse(safe[i + 1]);

                string element = string.Empty;

                if (name.Length == 3)
                {
                    element = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    element = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    element = "Gold";
                }

                if (element == "")
                {
                    continue;
                }
                else if (input < bag.Values.Select(x => x.Values.Sum()).Sum() + count)
                {
                    continue;
                }

                switch (element)
                {
                    case "Gem":
                        if (!bag.ContainsKey(element))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (count > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[element].Values.Sum() + count > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(element))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (count > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[element].Values.Sum() + count > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(element))
                {
                    bag[element] = new Dictionary<string, long>();
                }

                if (!bag[element].ContainsKey(name))
                {
                    bag[element][name] = 0;
                }

                bag[element][name] += count;
                if (element == "Gold")
                {
                    gold += count;
                }
                else if (element == "Gem")
                {
                    gems += count;
                }
                else if (element == "Cash")
                {
                    money += count;
                }
            }

            foreach (var kvp in bag)
            {
                Console.WriteLine($"<{kvp.Key}> ${kvp.Value.Values.Sum()}");
                foreach (var value in kvp.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{value.Key} - {value.Value}");
                }
            }
        }
    }
}