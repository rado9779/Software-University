using System;

namespace _01._Christmas_Sweets
{
    class Program
    {
        static void Main(string[] args)
        {
            double baklava = double.Parse(Console.ReadLine());
            double muffin = double.Parse(Console.ReadLine());
            double stollenKg = double.Parse(Console.ReadLine());
            double candyKg = double.Parse(Console.ReadLine());
            double biscuitsKg = double.Parse(Console.ReadLine());

            double stollenPrice = baklava + (baklava * 0.60);
            double candyPrice = muffin + (muffin * 0.80);
            double biscuitsPrice = 7.50;

            double stollenSum = stollenKg * stollenPrice;
            double candySum = candyKg * candyPrice;
            double biscuitSum = biscuitsKg * biscuitsPrice;

            double totalSum = stollenSum + candySum + biscuitSum;
            Console.WriteLine($"{totalSum:f2}");


        }
    }
}
