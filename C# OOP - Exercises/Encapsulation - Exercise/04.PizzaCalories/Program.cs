using _04.PizzaCalories.Models;
using System;

namespace _04.PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] pizzaElements = Console.ReadLine()
                    .Split();

                string pizzaName = pizzaElements[1];

                string[] doughElements = Console.ReadLine()
                    .Split();

                string doughFlourType = doughElements[1];
                string doughBakintTechnique = doughElements[2];
                double doughWeight = double.Parse(doughElements[3]);

                Dough dough = new Dough(doughFlourType, doughBakintTechnique, doughWeight);
                Pizza pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    string[] elements = Console.ReadLine()
                      .Split();

                    if (elements[0] == "END")
                    {
                        break;
                    }

                    string toppingType = elements[1];
                    double toppingWeight = double.Parse(elements[2]);

                    Topping topping = new Topping(toppingType,toppingWeight);
                    pizza.AddTopping(topping);
                }
                Console.WriteLine(pizza.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
