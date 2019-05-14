using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, int>>();

            while(true)
            {
                string line = Console.ReadLine();
                if (line == "Season end")
                {
                    break;
                }
                if (line.Contains("->"))
                {
                    string[] splitted = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                    string player = splitted[0];
                    string position = splitted[1];
                    int skill = int.Parse(splitted[2]);

                    if (!result.ContainsKey(player))
                    {
                        result.Add(player, new Dictionary<string, int>());
                        result[player].Add(position, skill);
                    }
                    else
                    {
                        if (!result[player].ContainsKey(position))
                        {
                            result[player].Add(position, skill);
                        }
                        else
                        {
                            if (result[player][position] < skill)
                            {
                                result[player][position] = skill;
                            }
                        }
                    }
                }
                if (line.Contains("vs"))
                {
                    string[] splitted = line.Split(new string[] { " vs " }, StringSplitOptions.RemoveEmptyEntries);
                    string firstPlayer = splitted[0];
                    string secondPlayer = splitted[1];
                    if (result.ContainsKey(firstPlayer) && result.ContainsKey(secondPlayer))
                    {
                        string toRemove = "";
                        foreach (var first in result[firstPlayer])
                        {
                            foreach (var second in result[secondPlayer])
                            {
                                if (first.Key == second.Key)
                                {
                                    if (result[firstPlayer].Values.Sum() > result[secondPlayer].Values.Sum())
                                    {
                                        toRemove = secondPlayer;
                                    }
                                    else 
                                    {
                                        toRemove = firstPlayer;
                                    }
                                }
                            }
                        }
                        result.Remove(toRemove);
                    }
                }
            }
            foreach (var player in result.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var kvp in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }
        }
    }
}
