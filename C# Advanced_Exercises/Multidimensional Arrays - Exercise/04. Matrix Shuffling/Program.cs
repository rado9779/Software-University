using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSizes = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            string[,] matrix = new string[matrixSizes[0], matrixSizes[1]];

            FillMatrix(matrixSizes, matrix);

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string command = line[0];

                if (command == "END")
                {
                    break;
                }
                else if (command == "swap" && line.Length == 5)
                {
                    int row1 = int.Parse(line[1]);
                    int col1 = int.Parse(line[2]);

                    int row2 = int.Parse(line[3]);
                    int col2 = int.Parse(line[4]);

                    if (ValidateCoordinates(matrixSizes, row1, col1) == true &&
                        ValidateCoordinates(matrixSizes, row2, col2) == true)
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        PrintMatrix(matrixSizes, matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
        public static bool ValidateCoordinates(int[] matrixSizes, int row, int col)
        {
            if (row >= 0 && row < matrixSizes[0] && col >= 0 && col < matrixSizes[1])
            {
                return true;
            }

            return false;
        }
        public static void PrintMatrix(int[] matrixSizes,string[,] matrix)
        {
            for (int row = 0; row < matrixSizes[0]; row++)
            {
                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void FillMatrix(int[] matrixSizes,string[,] matrix)
        {
            for (int row = 0; row < matrixSizes[0]; row++)
            {
                string[] colElements = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int col = 0; col < matrixSizes[1]; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }
    }
}
