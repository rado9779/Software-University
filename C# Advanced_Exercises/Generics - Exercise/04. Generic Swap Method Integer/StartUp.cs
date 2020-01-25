using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
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
                Swap(box.Values, firstIndex, secondIndex);
            }

            foreach (var value in box.Values)
            {
                Console.WriteLine($"{value.GetType().FullName}: {value}");
            }
        }
        public static bool IsValidIndex(int index, Box<int> box)
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
