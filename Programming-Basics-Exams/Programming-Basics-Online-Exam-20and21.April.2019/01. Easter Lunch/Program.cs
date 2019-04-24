using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double kozunakPrice = 3.20;
            double eggPrice = 4.35;
            double kyrabiqPrice = 5.40;
            double eggPaintPrice = 0.15;

            int kozunaciCount = int.Parse(Console.ReadLine());
            int eggsCount = int.Parse(Console.ReadLine());
            int kyrabiiKg = int.Parse(Console.ReadLine());

            double totalKozynaci = kozunaciCount * kozunakPrice;
            double totalEggs = eggsCount * eggPrice;
            double totalKyrabii = kyrabiiKg * kyrabiqPrice;
            double totalPaint = (eggsCount * 12) * eggPaintPrice;

            double totalSum = totalKozynaci + totalEggs + totalKyrabii + totalPaint;
            Console.WriteLine($"{totalSum:f2}");

         

        }
    }
}
