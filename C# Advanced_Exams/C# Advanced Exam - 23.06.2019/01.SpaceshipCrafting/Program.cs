using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01.SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
                {"Glass",0},
                {"Aluminium",0},
                {"Lithium",0},
                {"Carbon fiber",0}
            };
            Dictionary<int, string> scale = new Dictionary<int, string>()
            {
                {25,"Glass"},
                {50,"Aluminium"},
                {75,"Lithium"},
                {100,"Carbon fiber"}
            };

            Queue<int> chemicalLiquids = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> physicalItems = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            while (chemicalLiquids.Count > 0 && physicalItems.Count > 0)
            {
                int liquid = chemicalLiquids.Peek();
                int item = physicalItems.Peek();

                int sum = liquid + item;

                if (scale.ContainsKey(sum))
                {
                    string element = scale[sum];
                    materials[element]++;
                    chemicalLiquids.Dequeue();
                    physicalItems.Pop();
                }
                else
                {
                    chemicalLiquids.Dequeue();
                    physicalItems.Push(physicalItems.Pop() + 3);
                }
            }

            if (materials["Glass"] > 0 && materials["Aluminium"] > 0 &&
                materials["Lithium"] > 0 && materials["Carbon fiber"] > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (chemicalLiquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", chemicalLiquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (physicalItems.Count > 0)
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", physicalItems)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            foreach (var material in materials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

        }
    }
}
