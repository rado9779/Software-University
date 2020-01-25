using System;

namespace DateModifier
{
    class StartUp
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            DateModifier dateModifier = new DateModifier();

            Console.WriteLine(dateModifier.DifferenceInDays(firstDate,secondDate));
        }
    }
}
