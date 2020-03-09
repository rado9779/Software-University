using System;

using _04.WildFarm.Models.Foods;

namespace _04.WildFarm.Factories
{
    public static class FoodFactory
    {
        public static Food Create(string[] input)
        {
            string type = input[0];
            int quantity = int.Parse(input[1]);

            switch (input[0])
            {
                case nameof(Vegetable):
                    return new Vegetable(quantity);
                case nameof(Fruit):
                    return new Fruit(quantity);
                case nameof(Meat):
                    return new Meat(quantity);
                case nameof(Seeds):
                    return new Seeds(quantity);
                default:
                    throw new ArgumentException($"{type} is not a valid Food");
            }
        }
    }
}
