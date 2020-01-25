using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = line[0];

                if (command == "END")
                {
                    break;
                }

                string carNumber = line[1];

                if (command == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                else if (command == "OUT")
                {
                    carNumbers.Remove(carNumber);
                }
            }

            if (carNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine,carNumbers));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
