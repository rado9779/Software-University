using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                box.Add(value);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            if (IsValidIndex(firstIndex, box) && IsValidIndex(secondIndex, box))
            {
                //var temp = box.Values[firstIndex];
                //box.Values[firstIndex] = box.Values[secondIndex];
                //box.Values[secondIndex] = temp;

                Swap(box.Values, firstIndex, secondIndex);
            }

            foreach (var value in box.Values)
            {
                Console.WriteLine($"{value.GetType().FullName}: {value}");
            }


        }
        public static bool IsValidIndex(int index, Box<string> box)
        {
            if (index >= 0 && index < box.Count)
            {
                return true;
            }
            return false;
        }
        public static void Swap<T>(List<T> box, int firstIndex, int secondIndex)
        {
            var temp = box[firstIndex];
            box[firstIndex] = box[secondIndex];
            box[secondIndex] = temp;
        }

    }
}
