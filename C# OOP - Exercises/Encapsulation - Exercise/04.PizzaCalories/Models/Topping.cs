using System;

using _04.PizzaCalories.Utilities;

namespace _04.PizzaCalories.Models
{
    public class Topping
    {
        private string type;
        private double weight;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }
        public string Type 
        {
            get
            {
                return this.type;
            }
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" &&
                    value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidToppingType, value));
                }
                this.type = value;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < Constants.toppingMinWeight || value > Constants.toppingMaxWeight)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidToppingWeight,this.Type));
                }
                this.weight = value;
            }
        }
        public double CalculateToppingCalories()
        {
            double calories = this.Weight * Constants.toppingBaseCaloriesModifer;
            calories = MultiplyByToppingTypeModifer(calories);
            return calories;

        }
        public double MultiplyByToppingTypeModifer(double result)
        {
            switch (this.Type.ToLower())
            {
                case "meat":
                    result *= 1.2;
                    break;
                case "veggies":
                    result *= 0.8;
                    break;
                case "cheese":
                    result *= 1.1;
                    break;
                case "sauce":
                    result *= 0.9;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
