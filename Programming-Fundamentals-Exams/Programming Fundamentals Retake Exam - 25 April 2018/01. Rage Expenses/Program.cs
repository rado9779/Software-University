using System;

namespace _01._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalExpenses = 0;
            int keyboardTrashes = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    totalExpenses += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    totalExpenses += mousePrice;
                }
                if (i % 2 == 0 && i % 3 == 0)
                {
                    totalExpenses += keyboardPrice;
                    keyboardTrashes++;
                    if (keyboardTrashes % 2 == 0)
                    {
                        totalExpenses += displayPrice;
                    }
                }
            }
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
