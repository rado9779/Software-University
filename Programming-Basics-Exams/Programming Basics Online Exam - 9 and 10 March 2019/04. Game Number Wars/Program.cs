using System;

namespace _04._Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();

            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            while (true)
            {
                string first = Console.ReadLine();
                if (first == "End of game")
                {
                    Console.WriteLine($"{firstPlayer} has {firstPlayerPoints} points");
                    Console.WriteLine($"{secondPlayer} has {secondPlayerPoints} points");
                    break;
                }
                int second = int.Parse(Console.ReadLine());

                if (int.Parse(first) > second)
                {
                    firstPlayerPoints += int.Parse(first) - second;
                }
                else if (second > int.Parse(first))
                {
                    secondPlayerPoints += second - int.Parse(first);
                }
                else if (int.Parse(first) == second)
                {
                    Console.WriteLine("Number wars!");
                    int one = int.Parse(Console.ReadLine());
                    int two = int.Parse(Console.ReadLine());
                    if (one > two)
                    {
                        Console.WriteLine($"{firstPlayer} is winner with {firstPlayerPoints} points");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{secondPlayer} is winner with {secondPlayerPoints} points");
                        break;
                    }
                }


            }
        }
    }
}
