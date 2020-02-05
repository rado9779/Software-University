using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = parameters[0];

                //Engine
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                //Cargo
                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                //First Tire
                double firstTirePressure = double.Parse(parameters[5]);
                int firstTireAge = int.Parse(parameters[6]);
                Tire firstTire = new Tire(firstTirePressure, firstTireAge);

                //Second Tire
                double secondTirePressure = double.Parse(parameters[7]);
                int secondTireAge = int.Parse(parameters[8]);
                Tire secondTire = new Tire(secondTirePressure, secondTireAge);

                //Third Tire
                double thirdTirePressure = double.Parse(parameters[9]);
                int thirdTireAge = int.Parse(parameters[10]);
                Tire thirdTire = new Tire(thirdTirePressure, thirdTireAge);

                //Fourth Tire
                double fourthTirePressure = double.Parse(parameters[11]);
                int fourthTireAge = int.Parse(parameters[12]);
                Tire fourthTire = new Tire(fourthTirePressure, fourthTireAge);

                cars.Add(new Car(model, engine, cargo, firstTire, secondTire, thirdTire, fourthTire));
            }
            string command = Console.ReadLine();
            Car.SortCars(command, cars);
        }
    }
}
