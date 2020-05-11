using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Iron_Girder
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = new Dictionary<string, int>();
            var passengers = new Dictionary<string,int>();


            while (true)
            {
                string[] line = Console.ReadLine().Split(':');
                if (line[0] == "Slide rule")
                {
                    break;
                }

                if (line[1].Contains("ambush"))
                {
                    string[] ambush = line[1].Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                    string town = line[0];
                    int currentPassengers = int.Parse(ambush[1]);
                    if (times.ContainsKey(town))
                    {
                        times[town] = 0;
                        passengers[town] -= currentPassengers;
                    }
                }
                else
                {
                    string town = line[0];
                    string[] timeAndPassengers = line[1].Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                    int time = int.Parse(timeAndPassengers[0]);
                    int currentPassengers = int.Parse(timeAndPassengers[1]);

                    if (!times.ContainsKey(town))
                    {
                        times.Add(town, time);
                        passengers.Add(town, currentPassengers);
                    }
                    else
                    {
                        passengers[town] += currentPassengers;
                        if (times[town] > time || times[town] == 0)
                        {
                            times[town] = time;
                        }
                    }
                }
            }
            foreach (var town in times.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                if (town.Value == 0 || passengers[town.Key] == 0)
                {
                    continue;
                }
                Console.WriteLine($"{town.Key} -> Time: {town.Value} -> Passengers: {passengers[town.Key]}");
            }
        }
    }
}
