﻿using _04.WildFarm.Models.Foods;

namespace _04.WildFarm.Models.Animals.Birds
{

    public class Hen : Bird
    {
        private const double WeightPerFood = 0.35;

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            this.Weight += food.Quantity * WeightPerFood;
            this.FoodEaten += food.Quantity;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
