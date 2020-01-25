using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[matrixSize[0], matrixSize[1]];
            

            for (int row = 0; row < matrixSize[0]; row++)
            {
                char[] colElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrixSize[1]; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            Console.WriteLine(NumberOfSquaresInMatrix(matrix,matrixSize));

        }
        public static int NumberOfSquaresInMatrix(char[,] matrix, int[] matrixSizes)
        {
            int count = 0;

            for (int row = 0; row < matrixSizes[0] - 1; row++)
            {
                for (int col = 0; col < matrixSizes[1] - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row + 1, col] == matrix[row + 1, col + 1]
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
