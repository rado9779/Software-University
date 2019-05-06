using System;
using System.Text.RegularExpressions;

namespace _03._Chore_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string dishPattern = @"<([a-z0-9]+)>";
            Regex dishesRegex = new Regex(dishPattern);

            string cleanPattern = @"\[([A-Z0-9]+)\]";
            Regex cleanRegex = new Regex(cleanPattern);

            string laundryPattern = @"[{](.+)[}]";
            Regex laundryRegex = new Regex(laundryPattern);

            int dishTime = 0;
            int cleanTime = 0;
            int laundryTime = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "wife is happy")
                {
                    break;
                }
                if (dishesRegex.IsMatch(line))
                {
                    Match mathced = dishesRegex.Match(line);
                    string value = mathced.Groups[1].Value;
                    int time = DigitsSum(value);

                    dishTime += time;
                }
                if (cleanRegex.IsMatch(line))
                {
                    Match mathced = cleanRegex.Match(line);
                    string value = mathced.Groups[1].Value;
                    int time = DigitsSum(value);

                    cleanTime += time;
                }
                if (laundryRegex.IsMatch(line))
                {
                    Match mathced = laundryRegex.Match(line);
                    string value = mathced.Groups[1].Value;
                    int time = DigitsSum(value);

                    laundryTime += time;
                }
            }
            Console.WriteLine($"Doing the dishes - {dishTime} min.");
            Console.WriteLine($"Cleaning the house - {cleanTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
            Console.WriteLine("Total - {0} min.",dishTime + cleanTime + laundryTime);
        }
        public static int DigitsSum(string line)
        {
            int sum = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (char.IsDigit(line[i]))
                {
                    sum += int.Parse(line[i].ToString());
                }
            }
            return sum;
        }

    }
}
