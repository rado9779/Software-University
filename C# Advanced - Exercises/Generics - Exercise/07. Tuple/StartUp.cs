using System;

namespace _07.Tuple
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

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, address);

            line = Console.ReadLine()
                .Split();

            string name = line[0];
            int litersOfBeer = int.Parse(line[1]);

            Tuple<string, int> secondTuple = new Tuple<string, int>(name, litersOfBeer);

            line = Console.ReadLine()
                .Split();

            int integerNumber = int.Parse(line[0]);
            double doubleNumber = double.Parse(line[1]);

            Tuple<int, double> thirdTuple = new Tuple<int, double>(integerNumber, doubleNumber);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
