using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End of battle")
                {
                    break;
                }
                // first Player wins
                if (line == "one")
                {
                    secondPlayerEggs--;
                    if (secondPlayerEggs == 0)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
                        break;
                    }
                }
                else if (line == "two")
                {
                    firstPlayerEggs--;
                    if (firstPlayerEggs == 0)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
                        break;
                    }
                }
            }
            if (firstPlayerEggs > 0 && secondPlayerEggs > 0)
            {
                Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
                Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
            }
        }
    }
}
