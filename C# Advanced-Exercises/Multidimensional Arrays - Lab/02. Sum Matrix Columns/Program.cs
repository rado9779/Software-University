using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrixSize[0]; row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrixSize[1]; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            for (int col = 0; col < matrixSize[1]; col++)
            {
                int sum = 0;
                for (int row = 0; row < matrixSize[0]; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }

        }
    }
}
