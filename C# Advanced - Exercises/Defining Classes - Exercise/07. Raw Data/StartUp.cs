using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = line[0];

                int engineSpeed = int.Parse(line[1]);
                int enginePower = int.Parse(line[2]);

                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(line[3]);
                string cargoType = line[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                //Tyre 1
                double tire1Pressure = double.Parse(line[5]);
                int tire1Age = int.Parse(line[6]);
                Tire tire1 = new Tire(tire1Pressure, tire1Age);

                //Tyre 2
                double tire2Pressure = double.Parse(line[7]);
                int tire2Age = int.Parse(line[8]);
                Tire tire2 = new Tire(tire2Pressure, tire2Age);

                //Tyre 3
                double tire3Pressure = double.Parse(line[9]);
                int tire3Age = int.Parse(line[10]);
                Tire tire3 = new Tire(tire3Pressure, tire3Age);

                //Tyre 4
                double tire4Pressure = double.Parse(line[11]);
                int tire4Age = int.Parse(line[12]);
                Tire tire4 = new Tire(tire4Pressure, tire4Age);

                Tire[] tires = new Tire[] { tire1, tire2, tire3, tire4 };

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars = cars
                    .Where(x => x.Cargo.CargoType == "fragile")
                    .Where(x => x.Tires.Any(t => t.Pressure < 1))
                    .ToList();
            }
            else if (command == "flamable")
            {
                cars = cars
                   .Where(x => x.Cargo.CargoType == "flamable")
                   .Where(x => x.Engine.EnginePower > 250)
                   .ToList();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
