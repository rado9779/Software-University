using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsFor1m = double.Parse(Console.ReadLine());

            double slowMove = Math.Floor(distanceInMeters / 50) * 30;
            double time = (distanceInMeters * timeInSecondsFor1m) + slowMove;

            //Success
            if (time < recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {time:f2} seconds.");
            }
            //Failed
            else
            {
                Console.WriteLine("No! He was {0:f2} seconds slower.",time-recordInSeconds);
            }
        }
    }
}
