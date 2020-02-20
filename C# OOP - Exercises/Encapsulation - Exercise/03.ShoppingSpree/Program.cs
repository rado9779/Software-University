using System;
using System.Collections.Generic;
using System.Linq;
using _03.ShoppingSpree.Models;

namespace _03.ShoppingSpree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] line = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            string[] productInput = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                AddPersons(line, people);
                AddProducts(productInput, products);

                while (true)
                {
                    string[] input = Console.ReadLine()
                         .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    if (input[0] == "END")
                    {
                        break;
                    }

                    var person = people.FirstOrDefault(x => x.Name == input[0]);
                    var product = products.FirstOrDefault(x => x.Name == input[1]);

                    if (person != null && product != null)
                    {
                        if (person.CanBuyAProduct(product) == true)
                        {
                            Console.WriteLine($"{person.Name} bought {product.Name}");
                        }
                        else
                        {
                            Console.WriteLine($"{person.Name} can't afford {product.Name}");
                        }
                    }
                }

                foreach (var person in people)
                {
                    Console.WriteLine(person.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }


        }
        public static void AddPersons(string[] line, List<Person> people)
        {
            for (int i = 0; i < line.Length; i++)
            {
                string[] elements = line[i]
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);

                string name = elements[0];
                decimal money = decimal.Parse(elements[1]);
                Person person = new Person(name, money);
                people.Add(person);
            }
        }
        public static void AddProducts(string[] productInput, List<Product> products)
        {
            for (int i = 0; i < productInput.Length; i++)
            {
                string[] elements = productInput[i]
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);

                string name = elements[0];
                decimal price = decimal.Parse(elements[1]);
                Product product = new Product(name, price);
                products.Add(product);
            }
        }

    }
}
