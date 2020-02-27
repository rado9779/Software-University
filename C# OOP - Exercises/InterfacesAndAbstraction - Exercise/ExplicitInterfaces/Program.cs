using System;

using ExplicitInterfaces.Models;
using ExplicitInterfaces.Interfaces;

namespace ExplicitInterfaces
{
    public class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split();

                if (line[0] == "End")
                {
                    break;
                }

                Citizen citizen = new Citizen(line[0], line[1], int.Parse(line[2]));

                Console.WriteLine(citizen.GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}
