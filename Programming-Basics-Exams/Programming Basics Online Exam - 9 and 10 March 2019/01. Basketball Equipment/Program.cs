using System;

namespace _01._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int charge = int.Parse(Console.ReadLine());

            double sneakers = charge - (charge * 0.40);
            double outfit = sneakers - (sneakers * 0.20);
            double ball = outfit / 4;
            double accessories = ball / 5;

            double totalSum = charge + sneakers + outfit + ball + accessories;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
