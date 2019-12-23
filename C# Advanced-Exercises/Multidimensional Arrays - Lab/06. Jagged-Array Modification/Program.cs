using System;
using System.Linq;

namespace _6.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[matrixRows][];

            for (int row = 0; row < matrixRows; row++)
            {
                int[] col = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();

                matrix[row] = col;
            }

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = line[0];

                if (command == "END")
                {
                    break;
                }

                int inputRow = int.Parse(line[1]);
                int inputCol = int.Parse(line[2]);
                int value = int.Parse(line[3]);


                if (ValidateCoordinates(inputRow, inputCol, matrixRows))
                {
                    if (command == "Add")
                    {
                        matrix[inputRow][inputCol] += value;
                    }
                    else if (command == "Subtract")
                    {
                        matrix[inputRow][inputCol] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            PrintMatrix(matrix,matrixRows);
        }
        public static bool ValidateCoordinates(int row, int col, int rows)
        {
            if (row >= 0 && row < rows && col >= 0 && col < rows)
            {
                return true;
            }
            return false;
        }
        public static void PrintMatrix(int[][] matrix,int rows)
        {
            for (int row = 0; row < rows ; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
