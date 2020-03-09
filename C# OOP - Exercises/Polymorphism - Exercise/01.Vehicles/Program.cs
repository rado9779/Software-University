using System;

using _01.Vehicles.Models;

namespace _01.Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] carElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(carElements[1]);
            double carFuelConsumption = double.Parse(carElements[2]);

            Car car = new Car(carFuelQuantity, carFuelConsumption);

            string[] truckElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double truckFuelQuantity = double.Parse(truckElements[1]);
            double truckFuelConsumption = double.Parse(truckElements[2]);

            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = line[0];
                string type = line[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(line[2]);

                    if (type == "Car")
                    {
                        Console.WriteLine(car.Drive(distance));
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(distance));
                    }
                }
                else if (command == "Refuel")
                {
                    double fuel = double.Parse(line[2]);

                    if (type == "Car")
                    {
                        car.Refuel(fuel);
                    }
                    else
                    {
                        truck.Refuel(fuel);
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
