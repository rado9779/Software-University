using System;

using _04.PizzaCalories.Utilities;

namespace _04.PizzaCalories.Models
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType 
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDoughType);
                }
                this.flourType = value;
            }
        }
        public string BakingTechnique 
        {
            get
            {
                return this.bakingTechnique;
            }
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDoughType);
                }
                this.bakingTechnique = value;
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
                if (value < Constants.doughMinWeight || value > Constants.doughMaxWeight)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidDoughWeight);
                }
                this.weight = value;
            }
        }
        public double CalculateDoughCalories()
        {
            double calories = this.Weight * Constants.doughBaseCaloriesModifier;
            calories = MultiplyByBakeModifer(calories);
            calories = MultiplyByFlourModifer(calories);
            return calories;
        }
        public double MultiplyByBakeModifer(double result)
        {
            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    result *= 0.9;
                    break;
                case "chewy":
                    result *= 1.1;
                    break;
                case "homemade":
                    result *= 1.0;
                    break;
                default:
                    break;
            }
            return result;
        }
        public double MultiplyByFlourModifer(double result)
        {
            switch (this.FlourType.ToLower())
            {
                case "white":
                    result *= 1.5;
                    break;
                case "wholegrain":
                    result *= 1.0;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
