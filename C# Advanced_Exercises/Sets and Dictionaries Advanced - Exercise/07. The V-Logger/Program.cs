using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> result = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while (true)
            {
                string[] line = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == "Statistics")
                {
                    break;
                }

                string vloggername = line[0];
                string command = line[1];
                string star = line[2];

                if (command == "joined")
                {
                    if (result.ContainsKey(vloggername) == false)
                    {
                        result.Add(vloggername, new Dictionary<string, HashSet<string>>());
                        result[vloggername].Add("followers", new HashSet<string>());
                        result[vloggername].Add("followings", new HashSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    if (result.ContainsKey(vloggername) && result.ContainsKey(star) && star != vloggername)
                    {
                        result[star]["followers"].Add(vloggername);
                        result[vloggername]["followings"].Add(star);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {result.Count} vloggers in its logs.");

            var sorted = result
               .OrderByDescending(v => v.Value["followers"].Count)
               .ThenBy(v => v.Value["followings"].Count)
               .ToDictionary(k => k.Key, y => y.Value);

            int count = 1;
            foreach (var (name, value) in sorted)
            {
                int followersCount = sorted[name]["followers"].Count;
                int followingCount = sorted[name]["followings"].Count;

                Console.WriteLine($"{count}. {name} : {followersCount} followers, {followingCount} following");
                if (count == 1)
                {
                    var followers = sorted[name]["followers"].OrderBy(x => x).ToList();
                    foreach (var follower in followers)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
        }
    }
}
