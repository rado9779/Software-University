using System;

using _04.WildFarm.Models.Animals;
using _04.WildFarm.Models.Animals.Birds;
using _04.WildFarm.Models.Animals.Mammals;
using _04.WildFarm.Models.Animals.Mammals.Felines;

namespace _04.WildFarm.Factories
{
    public static class AnimalFactory
    {
        public static Animal Create(string[] input)
        {
            string type = input[0];

            switch (type)
            {
                case nameof(Owl):
                    return new Owl(input[1], double.Parse(input[2]), double.Parse(input[3]));
                case nameof(Hen):
                    return new Hen(input[1], double.Parse(input[2]), double.Parse(input[3]));
                case nameof(Cat):
                    return new Cat(input[1], double.Parse(input[2]), input[3], input[4]);
                case nameof(Tiger):
                    return new Tiger(input[1], double.Parse(input[2]), input[3], input[4]);
                case nameof(Dog):
                    return new Dog(input[1], double.Parse(input[2]), input[3]);
                case nameof(Mouse):
                    return new Mouse(input[1], double.Parse(input[2]), input[3]);
                default:
                    throw new ArgumentException($"{type} is not a valid Animal type.");
            }
        }
    }
}
