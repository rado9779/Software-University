using System;
using System.Collections.Generic;

namespace _5._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                if (line == "Paid")
                {
                    foreach (var customer in queue)
                    {
                        Console.WriteLine(customer);
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(line);
                }
            }
            Console.WriteLine("{0} people remaining.", queue.Count);
        }
    }
}
