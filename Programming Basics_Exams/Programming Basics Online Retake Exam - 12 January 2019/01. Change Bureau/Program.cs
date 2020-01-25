using System;

namespace _01._Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double bitcoinToLeva = bitcoins * 1168;
            double yuanToDollar = yuan * 0.15;
            double dollarToLeva = yuanToDollar * 1.76;
            double levaToEuro = (bitcoinToLeva + dollarToLeva) / 1.95;
            double result = levaToEuro - (levaToEuro * (commission / 100 ));

            Console.WriteLine($"{result:f2}");

        }
    }
}
