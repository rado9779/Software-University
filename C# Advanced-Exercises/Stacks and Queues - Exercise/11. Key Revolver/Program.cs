using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulletPrice = int.Parse(Console.ReadLine());
            var barrelSize = int.Parse(Console.ReadLine());

            int[] inputBullets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] inputLocks = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(inputBullets);
            var locks = new Queue<int>(inputLocks);

            int shoots = 0;
            int shootedBullets = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                if (bullets.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    bullets.Pop();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                }

                shoots++;
                shootedBullets++;
                if (shoots == barrelSize && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    shoots = 0;
                }
            }
            if (locks.Count <= 0)
            {
                int profit = intelligence - (bulletPrice * shootedBullets);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${profit}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
