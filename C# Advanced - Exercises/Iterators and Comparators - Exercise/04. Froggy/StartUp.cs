using System;
using System.Linq;

namespace _04.Froggy
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Lake lake = new Lake(Console.ReadLine().Split(", ").Select(int.Parse));

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
