using System;

namespace _01._Google_Searches
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int users = int.Parse(Console.ReadLine());
            double moneyPerSearch = double.Parse(Console.ReadLine());

            double totalMoney = 0;

            for (int i = 1; i <= users; i++)
            {
                int word = int.Parse(Console.ReadLine());
                double money = 0;
                if (word <= 5 && word > 0)
                {
                    money = moneyPerSearch;
                }
                if (word == 1)
                {
                    money = moneyPerSearch * 2;
                }
                if (i % 3 == 0)
                {
                    money *= 3;
                }
                totalMoney += money;
            }
            totalMoney *= days;
            Console.WriteLine($"Total money earned for {days} days: {totalMoney:f2}");
        }
    }
}
