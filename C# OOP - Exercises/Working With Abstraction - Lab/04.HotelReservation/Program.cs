using System;

namespace _04.HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal pricePerDay = decimal.Parse(line[0]);
            int numberOfDays = int.Parse(line[1]);
            Season season = (Season)Enum.Parse(typeof(Season), line[2]);
            Discount discount = Discount.None;

            if (line.Length == 4)
            {
                 discount = (Discount)Enum.Parse(typeof(Discount), line[3]);
            }

            PriceCalculator calculator = new PriceCalculator(pricePerDay, numberOfDays, season, discount);
            decimal totalPrice = calculator.GetTotalPrice();
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
