using System;
using System.Linq;
using System.Collections.Generic;

using _05.FootballTeamGenerator.Models;
using _05.FootballTeamGenerator.Utilities;

namespace _05.FootballTeamGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            while (true)
            {
                try
                {
                    string line = Console.ReadLine();
                    if (line == "END")
                    {
                        break;
                    }

                    string[] lineElements = line
                        .Split(";");

                    string command = lineElements[0];
                    string teamName = lineElements[1];

                    if (command != "Team" && !teams.ContainsKey(teamName))
                    {
                        throw new ArgumentException(string.Format(ExceptionMessages.InvalidTeam, teamName));
                    }

                    if (command == "Team")
                    {
                        Team team = new Team(teamName);

                        if (!teams.ContainsKey(teamName) && team != null)
                        {
                            teams.Add(teamName, new Team(teamName));
                        }
                    }
                    else if (command == "Add")
                    {
                        AddTeam(lineElements, teamName, teams);
                    }
                    else if (command == "Remove")
                    {
                        string playerName = lineElements[2];
                        teams[teamName].RemovePlayer(playerName);
                    }
                    else if (command == "Rating")
                    {
                        if (teams.ContainsKey(teamName) == false)
                        {
                            throw new ArgumentException(string.Format(ExceptionMessages.InvalidTeam, teamName));
                        }

                        double totalStat = teams[teamName].Players.Sum(p => p.PlayerSkilllevel());
                        Console.WriteLine($"{teamName} - {Math.Round(totalStat)}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static void AddTeam(string[] lineElements, string teamName, Dictionary<string, Team> teams)
        {
            string name = lineElements[2];
            int endurance = int.Parse(lineElements[3]);
            int sprint = int.Parse(lineElements[4]);
            int dribble = int.Parse(lineElements[5]);
            int passing = int.Parse(lineElements[6]);
            int shooting = int.Parse(lineElements[7]);

            Stat stat = new Stat(endurance, sprint, dribble, passing, shooting);
            Player player = new Player(name, stat);
            teams[teamName].AddPlayer(player);
        }
    }
}
