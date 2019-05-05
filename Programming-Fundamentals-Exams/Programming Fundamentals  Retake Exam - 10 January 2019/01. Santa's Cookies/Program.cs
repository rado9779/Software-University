using System;

namespace _01._Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            double totalBoxes = 0;

            for (int i = 0; i < batches; i++)
            {
                int flourInGrams = int.Parse(Console.ReadLine());
                int sugarInGrams = int.Parse(Console.ReadLine());
                int cоcоаInGrams = int.Parse(Console.ReadLine());

                int flourCups = flourInGrams / 140;
                int sugarSpoons = sugarInGrams / 20;
                int cocoaSpoons = cоcоаInGrams / 10;
                if (flourCups <= 0 || sugarSpoons <= 0 || cocoaSpoons <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                    continue;
                }

                int min = Math.Min(flourCups, Math.Min(sugarSpoons, cocoaSpoons));
                int CookiesPerBake = ((140 + 10 + 20) * min) / 25;
                double boxesPerBatch = CookiesPerBake / 5;
                Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");
                totalBoxes += boxesPerBatch;
            }
            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
