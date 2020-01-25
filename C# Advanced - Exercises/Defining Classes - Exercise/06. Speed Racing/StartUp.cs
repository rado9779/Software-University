using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = line[0];
                double fuelAmount = double.Parse(line[1]);
                double fuelConsumptionFor1km = double.Parse(line[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(car);
            }

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string command = line[0];

                if (command == "End")
                {
                    break;
                }
                else if (command == "Drive")
                {
                    string carModel = line[1];
                    double distance = double.Parse(line[2]);

                    Car car = cars.FirstOrDefault(x => x.Model == carModel);
                    car.Drive(car.Model,distance);
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
