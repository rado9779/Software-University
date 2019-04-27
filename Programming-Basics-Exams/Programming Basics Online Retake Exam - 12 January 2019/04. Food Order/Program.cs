using System;

namespace _04._Food_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()) ;
            int itemsCount = 0;
            double totalCost = 2.50;

            while (true)
            {
                string product = Console.ReadLine();
                if (product == "Order")
                {
                    break;
                }
                double price = double.Parse(Console.ReadLine());
                if (totalCost + price <= budget)
                {
                    itemsCount++;
                    totalCost += price;
                }
                else 
                {
                    Console.WriteLine("You will exceed the budget if you order this!");
                }
            }
            Console.WriteLine($"You ordered {itemsCount} items!");
            Console.WriteLine($"Total: {totalCost:f2}");
        }
    }
}
