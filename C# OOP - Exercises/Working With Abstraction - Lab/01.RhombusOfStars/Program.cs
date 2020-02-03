using System;

namespace _01.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                PrintRow(size, row);
            }
            for (int row = size - 1; row > 0; row--)
            {
                PrintRow(size, row);
            }
        }
        public static void PrintRow(int size,int row)
        {
            for (int e = 1; e <= size - row; e++)
            {
                Console.Write(" ");
            }
            for (int s = 1; s < row; s++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }
    }
}
