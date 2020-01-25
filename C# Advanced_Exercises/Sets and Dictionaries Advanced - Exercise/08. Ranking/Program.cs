using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, double>> submissions = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] line = Console.ReadLine()
                     .Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == "end of contests")
                {
                    break;
                }

                string contest = line[0];
                string password = line[1];

                if (contests.ContainsKey(contest) == false)
                {
                    contests.Add(contest, password);
                }
            }

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == "end of submissions")
                {
                    break;
                }

                string contest = line[0];
                string password = line[1];
                string username = line[2];
                double points = double.Parse(line[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (submissions.ContainsKey(username) == false)
                    {
                        submissions.Add(username, new Dictionary<string, double>());
                    }
                    if (submissions[username].ContainsKey(contest) == false)
                    {
                        submissions[username].Add(contest, 0);
                    }
                    if (submissions[username][contest] < points)
                    {
                        submissions[username][contest] = points;
                    }
                }
            }

            var bestCandidate = submissions
                .OrderByDescending(x => x.Value.Sum(v => v.Value))
                .FirstOrDefault();

            var bestCanditatePoints = bestCandidate.Value.Values.Sum();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCanditatePoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var (name,contest) in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine(name);
                foreach (var (contestName,points) in contest.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestName} -> {points}");
                }
            }
        }
    }
}
