using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[matrixSizes[0], matrixSizes[1]];
            string snake = Console.ReadLine();

            int counter = 0;
            for (int row = 0; row < matrixSizes[0]; row++)
            {
                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    if (counter >= snake.Length)
                    {
                        counter = 0;
                    }
                    matrix[row, col] = snake[counter++];
                }
            }

            for (int row = 0; row < matrixSizes[0]; row++)
            {
                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }



        }
    }
}
