using System;

namespace _01._School_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            var pensCount = double.Parse(Console.ReadLine());
            var markersCount = double.Parse(Console.ReadLine());
            var deskCleanup = double.Parse(Console.ReadLine());
            var discount = double.Parse(Console.ReadLine());

            double penPrice = 5.80;
            double markerPrice = 7.20;
            double deskCleanupPrice = 1.20;

            double totalSum = (pensCount * penPrice) + (markersCount * markerPrice) + (deskCleanup * deskCleanupPrice);
            double sumWithDiscount = totalSum - (totalSum * (discount / 100));
            Console.WriteLine($"{sumWithDiscount:f3}");
        }
    }
}
