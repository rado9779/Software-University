using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<double> box = new Box<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double value = double.Parse(Console.ReadLine());
                box.Add(value);
            }

            double element = double.Parse(Console.ReadLine());

            Console.WriteLine(CountOfGraterElements(box.Data, element));
        }
        public static int CountOfGraterElements<T>(List<T> box, double element)
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
