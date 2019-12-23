using System;
using System.Linq;

namespace MultidimensionalArraysLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            int sum = 0;

            for (int row = 0; row < matrixSize[0]; row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrixSize[1]; col++)
                {
                    matrix[row, col] = colElements[col];
                    sum += colElements[col];
                }
            }

            Console.WriteLine(matrixSize[0]);
            Console.WriteLine(matrixSize[1]);
            Console.WriteLine(sum);
        }
    }
}
