using System;

namespace _04._Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {

            int kids = 0;
            int adults = 0;

            while (true)
            {
                string presents = Console.ReadLine();
                if (presents == "Christmas")
                {
                    break;
                }

                int age = int.Parse(presents);
                if (age <= 16)
                {
                    kids++;
                }
                else
                {
                    adults++;
                }
            }

            double toysMoney = kids * 5;
            double sweaterMoney = adults * 15;


            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {toysMoney}");
            Console.WriteLine($"Money for sweaters: {sweaterMoney}");
        }
    }
}
