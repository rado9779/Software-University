using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._MeTube_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var meTubeViews = new Dictionary<string, int>();
            var meTubeRate = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "stats time")
                {
                    break;
                }
                if (line.Contains('-'))
                {
                    string[] splitted = line.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                    string videoName = splitted[0];
                    int views = int.Parse(splitted[1]);
                    if (!meTubeViews.ContainsKey(videoName))
                    {
                        meTubeViews.Add(videoName, views);
                        meTubeRate.Add(videoName, 0);
                    }
                    else
                    {
                        meTubeViews[videoName] += views;
                    }
                }
                if (line.Contains(':'))
                {
                    string[] splitted = line.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                    string rate = splitted[0];
                    string videoName = splitted[1];
                    if (rate == "like")
                    {
                        if (meTubeRate.ContainsKey(videoName))
                        {
                            meTubeRate[videoName]++;
                        }
                    }
                    else if (rate == "dislike")
                    {
                        if (meTubeRate.ContainsKey(videoName))
                        {
                            meTubeRate[videoName]--;
                        }
                    }
                }
            }
            string criterion = Console.ReadLine();

            if (criterion == "by views")
            {
                foreach (var video in meTubeViews.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{video.Key} - {video.Value} views - {meTubeRate[video.Key]} likes");
                }
            }
            else if (criterion == "by likes")
            {
                foreach (var video in meTubeRate.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{video.Key} - {meTubeViews[video.Key]} views - {video.Value} likes");
                }
            }
        }
    }
}
