using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Santa_sPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> table = new Dictionary<int, string>()
            {
                {150,"Doll"},
                {250,"Wooden train"},
                {300,"Teddy bear"},
                {400,"Bicycle"}
            };

            SortedDictionary<string, int> presents = new SortedDictionary<string, int>();

            Stack<int> materials = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Queue<int> magicLevels = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while (materials.Count > 0 && magicLevels.Count > 0)
            {
                int material = materials.Peek();
                int magicLevel = magicLevels.Peek();

                if (material == 0)
                {
                    materials.Pop();
                }
                if (magicLevel == 0)
                {
                    magicLevels.Dequeue();
                }

                int totalMagicLevel = material * magicLevel;

                if (table.ContainsKey(totalMagicLevel))
                {
                    if (presents.ContainsKey(table[totalMagicLevel]) == false)
                    {
                        presents.Add(table[totalMagicLevel], 0);
                    }
                    presents[table[totalMagicLevel]]++;
                    materials.Pop();
                    magicLevels.Dequeue();
                }
                if (totalMagicLevel < 0)
                {
                    int sum = material + magicLevel;
                    materials.Pop();
                    magicLevels.Dequeue();
                    materials.Push(sum);
                }
                if (table.ContainsKey(totalMagicLevel) == false && totalMagicLevel > 0)
                {
                    magicLevels.Dequeue();
                    materials.Push(materials.Pop() + 15);
                }
            }

            if (presents.ContainsKey("Doll") && presents.ContainsKey("Wooden train") ||
                presents.ContainsKey("Teddy bear") && presents.ContainsKey("Bicycle"))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if (magicLevels.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicLevels)}");
            }


            foreach (var (toy, amount) in presents.Where(x => x.Value > 0))
            {
                Console.WriteLine($"{toy}: {amount}");
            }
        }
    }
}
