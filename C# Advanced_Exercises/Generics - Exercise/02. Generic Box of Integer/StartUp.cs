using System;

namespace _02.GenericBoxOfInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int line = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(line);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
