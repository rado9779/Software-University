using System;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                     .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = line[0];
                int age = int.Parse(line[1]);

                Console.WriteLine(name);
                Console.WriteLine(age);
            }
        }
    }
}
