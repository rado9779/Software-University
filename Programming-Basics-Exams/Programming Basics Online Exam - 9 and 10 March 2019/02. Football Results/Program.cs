using System;

namespace _02._Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstGame = Console.ReadLine().Split(':');
            string[] secondGame = Console.ReadLine().Split(':');
            string[] thirdGame = Console.ReadLine().Split(':');

            int lost = 0;
            int won = 0;
            int drawn = 0;

            //First Game
            if (int.Parse(firstGame[0]) > int.Parse(firstGame[1]))
            {
                won++;
            }
            else if (int.Parse(firstGame[0]) ==  int.Parse(firstGame[1]))
            {
                drawn++;
            }
            else if (int.Parse(firstGame[0]) < int.Parse(firstGame[1]))
            {
                lost++;
            }
            //Second Game 
            if (int.Parse(secondGame[0]) > int.Parse(secondGame[1]))
            {
                won++;
            }
            else if (int.Parse(secondGame[0]) == int.Parse(secondGame[1]))
            {
                drawn++;
            }
            else if (int.Parse(secondGame[0]) < int.Parse(secondGame[1]))
            {
                lost++;
            }
            //Third Game 
            if (int.Parse(thirdGame[0]) > int.Parse(thirdGame[1]))
            {
                won++;
            }
            else if (int.Parse(thirdGame[0]) == int.Parse(thirdGame[1]))
            {
                drawn++;
            }
            else if (int.Parse(thirdGame[0]) < int.Parse(thirdGame[1]))
            {
                lost++;
            }

            Console.WriteLine($"Team won {won} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {drawn}");
        }
    }
}
