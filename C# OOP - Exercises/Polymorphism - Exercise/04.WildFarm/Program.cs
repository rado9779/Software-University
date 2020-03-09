using System;
using System.Collections.Generic;

using _04.WildFarm.Factories;
using _04.WildFarm.Models.Foods;
using _04.WildFarm.Models.Animals;

namespace _04.WildFarm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (line[0] == "End")
                {
                    break;
                }

                string[] animalElemnts = line;
                string[] foodElements = Console.ReadLine().Split();

                Animal animal = AnimalFactory.Create(animalElemnts);
                Food food = FoodFactory.Create(foodElements);

                Console.WriteLine(animal.ProduceSound());

                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
