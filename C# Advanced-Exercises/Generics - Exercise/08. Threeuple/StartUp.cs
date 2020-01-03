using System;

namespace _08.Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
               .Split();

            string firstName = line[0];
            string lastName = line[1];
            string fullName = firstName + " " + lastName;
            string address = line[2];
            string town = line[3];

            Threeuple<string, string, string> firstTuple =
                new Threeuple<string, string, string>(fullName, address, town);

            line = Console.ReadLine()
                .Split();

            string name = line[0];
            int litersOfBeer = int.Parse(line[1]);
            bool isDrunk = line[2] == "drunk";

            Threeuple<string, int, bool> secondTuple = 
                new Threeuple<string, int, bool>(name, litersOfBeer, isDrunk);

            line = Console.ReadLine()
                .Split();

            string accountName = line[0];
            double accountBalance = double.Parse(line[1]);
            string bankName = line[2];

            Threeuple<string, double, string> thirdTuple =
                new Threeuple<string, double, string>(accountName, accountBalance, bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
