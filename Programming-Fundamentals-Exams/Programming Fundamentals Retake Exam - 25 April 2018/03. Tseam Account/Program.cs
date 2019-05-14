using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tseam_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split().ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Play!")
                {
                    Console.WriteLine(string.Join(' ', games));
                    break;
                }
                string[] splitted = line.Split();
                string command = splitted[0];
                string game = splitted[1];

                if (command == "Install")
                {
                    if (!games.Contains(game))
                    {
                        games.Add(game);
                    }
                }
                else if (command == "Uninstall")
                {
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                    }
                }
                else if (command == "Update")
                {
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                        games.Add(game);
                    }
                }
                else if (command == "Expansion")
                {
                    string[] gameSplit = game.Split('-');
                    if (games.Contains(gameSplit[0]))
                    {
                        int index = games.IndexOf(gameSplit[0]);
                        string toAdd = $"{gameSplit[0]}:{gameSplit[1]}";
                        games.Insert(index + 1, toAdd);
                    }
                }
            }
        }
    }
}
