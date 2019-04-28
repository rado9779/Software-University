using System;

namespace _06._Christmas_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            bool left = true;
            while (true)
            {
                string product = Console.ReadLine();
                if (product == "Stop")
                {
                    break;
                }
                double price = 0;
                for (int i = 0; i < product.Length; i++)
                {
                    price += product[i];
                }
                if (budget - price >= 0)
                {
                    budget -= price;
                    Console.WriteLine("Item successfully purchased!");
                }
                else
                {
                    Console.WriteLine("Not enough money!");
                    left = false;
                    break;
                }
            }
            if (left)
            {
                Console.WriteLine($"Money left: {budget}");
            }
        }
    }
}
