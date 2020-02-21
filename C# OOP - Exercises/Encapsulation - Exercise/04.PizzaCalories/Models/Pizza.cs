using System;
using System.Linq;
using System.Collections.Generic;

using _04.PizzaCalories.Utilities;

namespace _04.PizzaCalories.Models
{
    public class Pizza
    {
        private string name;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<Topping>();
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPizzaName);
                }
                this.name = value;
            }
        }
        public Dough Dough { get; private set; }

        public List<Topping> Toppings { get; private set; }

        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Count < Constants.toppingsMaxCount)
            {
                this.Toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidToppingCount);
            }
        }
        public double CalculatePizzaCalories()
        {
            double result = this.Dough.CalculateDoughCalories() +
                this.Toppings.Sum(x => x.CalculateToppingCalories());

            return result;
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.CalculatePizzaCalories():f2} Calories.";
        }
    }
}
