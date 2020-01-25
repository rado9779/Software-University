using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                box.Add(value);
            }

            string element = Console.ReadLine();

            Console.WriteLine(CountOfGraterElements(box.Data,element));
        }
        public static int CountOfGraterElements<T>(List<T> box, string element)
        {
            int count = 0;

            foreach (var boxElement in box)
            {
                if (element.CompareTo(boxElement) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
