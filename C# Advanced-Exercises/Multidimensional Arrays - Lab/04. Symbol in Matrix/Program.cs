using System;
using System.Linq;

namespace _04.SymbolinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                char[] colElements = Console.ReadLine().ToArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isFind = false;

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        isFind = true;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            if (isFind == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }
    }
}
