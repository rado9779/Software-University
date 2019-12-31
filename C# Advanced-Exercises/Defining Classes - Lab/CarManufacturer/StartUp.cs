using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        private const double distance = 20.0;

        public static void Main(string[] args)
        {
            List<Tire[]> allTires = new List<Tire[]>();
            List<Engine> allEngines = new List<Engine>();
            List<Car> allCars = new List<Car>();


            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split();

                //No more tires
                if (line[0] == "No")
                {
                    break;
                }

                Tire[] fourTires = new Tire[4]
                {
                        new Tire(int.Parse(line[0]),double.Parse(line[1])),
                        new Tire(int.Parse(line[2]),double.Parse(line[3])),
                        new Tire(int.Parse(line[4]),double.Parse(line[5])),
                        new Tire(int.Parse(line[6]),double.Parse(line[7])),
                };

                allTires.Add(fourTires);

            }

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //Engines done
                if (line[0] == "Engines")
                {
                    break;
                }

                for (int i = 0; i < line.Length - 1; i++)
                {
                    int engineHorsePower = int.Parse(line[i]);
                    double engineCubicCapacity = double.Parse(line[i + 1]);

                    Engine engine = new Engine(engineHorsePower, engineCubicCapacity);

                    allEngines.Add(engine);
                }

            }

            while (true)
            {

                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //Show special
                if (line[0] == "Show")
                {
                    break;
                }

                string make = line[0];
                string model = line[1];
                int year = int.Parse(line[2]);
                double fuelQuantity = double.Parse(line[3]);
                double fuelConsumption = double.Parse(line[4]);
                int engineIndex = int.Parse(line[5]);
                int tireIndex = int.Parse(line[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, allEngines[engineIndex],
                    allTires[tireIndex]);

                var isSpecialCar = IsSpecialCar(car);

                if (isSpecialCar)
                {
                    car.Drive(distance);
                }

                if (car.FuelQuantity != fuelQuantity)
                {
                    allCars.Add(car);
                }
            }

            foreach (var specialCar in allCars)
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
        private static bool IsSpecialCar(Car car)
        {
            return car.Year >= 2017 &&
                   car.Engine.HorsePower >= 330 &&
                   car.Tires.Select(x => x.Pressure).Sum() >= 9 &&
                   car.Tires.Select(x => x.Pressure).Sum() <= 10;
        }
    }
}

