using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = line[0];
                int power = int.Parse(line[1]);

                string displacement = "n/a";
                string efficiency = "n/a";

                if (line.Length == 3)
                {
                    if (char.IsDigit(line[2][0]))
                    {
                        displacement = line[2];
                    }
                    else
                    {
                        efficiency = line[2];
                    }
                }
                if (line.Length == 4)
                {
                    displacement = line[2];
                    efficiency = line[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] line = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = line[0];
                string engine = line[1];

                string weight = "n/a";
                string color = "n/a";

                if (line.Length == 3)
                {
                    if (char.IsDigit(line[2][0]))
                    {
                        weight = line[2];
                    }
                    else
                    {
                        color = line[2];
                    }
                }
                else if (line.Length == 4)
                {
                    weight = line[2];
                    color = line[3];
                }


                var carEngine = engines.FirstOrDefault(x => x.Model == engine);
                Car car = new Car(model, carEngine, weight, color);
                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.CarInfo());
            }
        }
    }
}
