using System;

namespace _01._Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double statuette = rent - (rent * 0.30);
            double catering = statuette - (statuette * 0.15);
            double sound = catering / 2;

            double totalSum = rent + statuette + catering + sound;
            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
