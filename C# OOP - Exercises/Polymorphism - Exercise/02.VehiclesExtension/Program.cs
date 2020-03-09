using System;

using _02.VehiclesExtension.Models;

namespace _02.VehiclesExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car
            string[] carElements = Console.ReadLine()
                 .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(carElements[1]);
            double carFuelConsumption = double.Parse(carElements[2]);
            double carTankCapacity = double.Parse(carElements[3]);

            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);

            //Truck
            string[] truckElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double truckFuelQuantity = double.Parse(truckElements[1]);
            double truckFuelConsumption = double.Parse(truckElements[2]);
            double truckTankCapacity = double.Parse(truckElements[3]);

            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

            //Bus
            string[] busElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double busFuelQuantity = double.Parse(busElements[1]);
            double busFuelConsumption = double.Parse(busElements[2]);
            double busTankCapacity = double.Parse(busElements[3]);

            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                try
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
                        else if (type == "Truck")
                        {
                            Console.WriteLine(truck.Drive(distance));
                        }
                        else if (type == "Bus")
                        {
                            Console.WriteLine(bus.Drive(distance));
                        }
                    }
                    else if (command == "Refuel")
                    {
                        double fuel = double.Parse(line[2]);

                        if (type == "Car")
                        {
                            car.Refuel(fuel);
                        }
                        else if (type == "Truck")
                        {
                            truck.Refuel(fuel);
                        }
                        else if (type == "Bus")
                        {
                            bus.Refuel(fuel);
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        double distance = double.Parse(line[2]);
                        Console.WriteLine(bus.DriveEmpty(distance));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
