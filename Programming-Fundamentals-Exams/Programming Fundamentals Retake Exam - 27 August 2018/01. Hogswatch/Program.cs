using System;

namespace _01._Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int homesToVisit = int.Parse(Console.ReadLine());
            int presents = int.Parse(Console.ReadLine());
            int initialPresents = presents;

            int backTimes = 0;
            double totalPresents = 0;

            for (int i = 1; i <= homesToVisit; i++)
            {
                int socks = int.Parse(Console.ReadLine());
                if (presents - socks < 0)
                {
                    backTimes++;
                    int presentsToTake = (initialPresents / i) * (homesToVisit - i) + (socks - presents);
                    presents += presentsToTake;
                    totalPresents += presentsToTake;
                    presents -= socks;
                }
                else
                {
                    presents -= socks;
                }
            }
            if (backTimes == 0)
            {
                Console.WriteLine(presents);
            }
            else
            {
                Console.WriteLine(backTimes);
                Console.WriteLine(totalPresents);
            }
        }
    }
}
