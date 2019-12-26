using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var stores = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == "Revision")
                {
                    break;
                }

                string store = line[0];
                string product = line[1];
                double price = double.Parse(line[2]);

                if (stores.ContainsKey(store) == false)
                {
                    stores.Add(store, new Dictionary<string, double>());
                }

                stores[store].Add(product, price);
            }

            foreach (var store in stores.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}->",store.Key);
                foreach (var product in store.Value)
                {
                    Console.WriteLine("Product: {0}, Price: {1}",product.Key,product.Value);
                }
            }
        }
    }
}
