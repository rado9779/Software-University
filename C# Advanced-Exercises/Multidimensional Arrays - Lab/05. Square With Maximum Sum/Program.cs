using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
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
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrixSize[1]; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            int maxSquareSum = 0;

            int topLeft = 0;
            int topRight = 0;
            int bottomLeft = 0;
            int bottomRight = 0;

            for (int row = 0; row < matrixSize[0] - 1; row++)
            {
                for (int col = 0; col < matrixSize[1] - 1; col++)
                {
                    int currentSquareSum = matrix[row, col]
                                         + matrix[row, col + 1]
                                         + matrix[row + 1, col]
                                         + matrix[row + 1, col + 1];

                    if (currentSquareSum > maxSquareSum)
                    {
                        maxSquareSum = currentSquareSum;

                        topLeft = matrix[row, col];
                        topRight = matrix[row, col + 1];
                        bottomLeft = matrix[row + 1, col];
                        bottomRight = matrix[row + 1, col + 1];

                       
                    }
                }
            }

            Console.WriteLine(topLeft + " " + topRight);
            Console.WriteLine(bottomLeft + " " + bottomRight);
            Console.WriteLine(maxSquareSum);
        }
    }
}
