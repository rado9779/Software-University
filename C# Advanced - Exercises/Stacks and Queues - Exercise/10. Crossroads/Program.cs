using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            var traffic = new Queue<string>();

            bool isHitted = false;
            string hittedCar = string.Empty;
            char index = '\0';
            int totalCars = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                if (command != "green")
                {
                    traffic.Enqueue(command);
                }
                else if (command == "green")
                {
                    int currentGreenLight = greenLightDuration;

                    while (currentGreenLight > 0 && traffic.Count > 0)
                    {
                        string car = traffic.Dequeue();
                        int carLenght = car.Length;

                        if (currentGreenLight - carLenght >= 0)
                        {
                            currentGreenLight -= carLenght;
                            totalCars++;
                        }
                        else
                        {
                            currentGreenLight += freeWindow;
                            if (currentGreenLight - car.Length >= 0)
                            {
                                totalCars++;
                                break;
                            }
                            else
                            {
                                isHitted = true;
                                hittedCar = car;
                                index = car[currentGreenLight];
                                break;
                            }
                        }
                    }
                }
                if (isHitted)
                {
                    break;
                }
            }
            if (isHitted)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{hittedCar} was hit at {index}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{totalCars} total cars passed the crossroads.");
            }
        }
    }
}
