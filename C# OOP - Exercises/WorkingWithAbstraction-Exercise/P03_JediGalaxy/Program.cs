using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int matrixRows = dimensions[0];
            int matrixCols = dimensions[1];

            int[,] matrix = FillMatrix(matrixRows,matrixCols);

            long sum = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Let the Force be with you")
                {
                    break;
                }

                int[] ivoCoordinates = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int[] evilCoordinates = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int enemyRow = evilCoordinates[0];
                int enemyCol = evilCoordinates[1];

                while (enemyRow >= 0 && enemyCol >= 0)
                {
                    if (ValidCoordinates(enemyRow,enemyCol,matrix))
                    {
                        matrix[enemyRow, enemyCol] = 0;
                    }
                    enemyRow--;
                    enemyCol--;
                }

                int playerRow = ivoCoordinates[0];
                int playerCol = ivoCoordinates[1];

                while (playerRow >= 0 && playerCol < matrixCols)
                {
                    if (ValidCoordinates(playerRow,playerCol,matrix))
                    {
                        sum += matrix[playerRow, playerCol];
                    }

                    playerCol++;
                    playerRow--;
                }
            }
            Console.WriteLine(sum);
        }
        public static int[,] FillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            int value = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = value++;
                }
            }
            return matrix;
        }
        public static bool ValidCoordinates(int row,int col,int[,] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
