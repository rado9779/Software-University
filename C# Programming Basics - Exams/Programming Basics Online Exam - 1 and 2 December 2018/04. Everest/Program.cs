using System;

namespace _04._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            int initalHeight = 5364;
            int goal = 8848;
            int days = 1;

            while (true)
            {
                string sleep = Console.ReadLine();
                if (sleep == "END")
                {
                    if (days >= 5 || initalHeight < goal)
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine(initalHeight);
                        break;
                    }
                }
                else if (sleep == "Yes")
                {
                    days++;
                    if (days > 5 && initalHeight < goal)
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine(initalHeight);
                        break;
                    }
                }
                int currentHeight = int.Parse(Console.ReadLine());
                initalHeight += currentHeight;
                if (initalHeight >= goal)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    break;
                }
            }
        }
    }
}
