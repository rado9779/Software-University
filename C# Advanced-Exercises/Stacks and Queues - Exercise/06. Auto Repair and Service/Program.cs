using System;
using System.Collections.Generic;

namespace _06._Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine()
              .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var carsInQueue = new Queue<string>(cars);
            var servedCars = new Stack<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    if (carsInQueue.Count > 0)
                    {
                        Console.WriteLine("Vehicles for service: {0}",
                            string.Join(", ", carsInQueue));
                    }
                    if (servedCars.Count > 0)
                    {
                        Console.WriteLine("Served vehicles: {0}",
                            string.Join(", ", servedCars));
                    }
                    break;
                }
                if (command == "Service" && carsInQueue.Count > 0)
                {
                    string car = carsInQueue.Dequeue();
                    servedCars.Push(car);
                    Console.WriteLine("Vehicle {0} got served.", car);
                }
                if (command.Contains("CarInfo"))
                {
                    string car = command.Split('-')[1];
                    if (carsInQueue.Contains(car))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }
            }
        }
    }
}
