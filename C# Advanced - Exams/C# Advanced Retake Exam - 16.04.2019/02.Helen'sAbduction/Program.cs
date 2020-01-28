using System;

namespace _02.Helen_sAbduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int parisEnergy = int.Parse(Console.ReadLine());
            int fieldSize = int.Parse(Console.ReadLine());

            char[][] field = new char[fieldSize][];
            FillMatrix(field, fieldSize);

            int[] parisPositions = FindParis(field, fieldSize);
            int parisRow = parisPositions[0];
            int parisCol = parisPositions[1];
            bool isParisDead = false;

            while (true)
            {
                int currentRow = parisRow;
                int currentCol = parisCol;

                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string direction = line[0];
                int spartanRow = int.Parse(line[1]);
                int spartanCol = int.Parse(line[2]);

                field[spartanRow][spartanCol] = 'S';
                parisEnergy--;

                field[parisRow][parisCol] = '-';

                switch (direction)
                {
                    case "up":
                        currentRow--;
                        break;
                    case "down":
                        currentRow++;
                        break;
                    case "left":
                        currentCol--;
                        break;
                    case "right":
                        currentCol++;
                        break;
                }

                if (ValidateIndeces(currentRow, currentCol, field, fieldSize) == true)
                {
                    parisRow = currentRow;
                    parisCol = currentCol;
                }

                if (field[parisRow][parisCol] == 'S')
                {
                    parisEnergy -= 2;
                    if (parisEnergy <= 0)
                    {
                        field[parisRow][parisCol] = 'X';
                        isParisDead = true;
                        break;
                    }
                    field[parisRow][parisCol] = 'P';
                }
                else if (field[parisRow][parisCol] == 'H')
                {
                    field[parisRow][parisCol] = '-';
                    break;
                }

                if (parisEnergy <= 0)
                {
                    field[parisRow][parisCol] = 'X';
                    isParisDead = true;
                    break;
                }
            }

            if (isParisDead == false)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {parisEnergy}");
            }
            else
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
            }
            PrintMatrix(field, fieldSize);
        }
        public static void FillMatrix(char[][] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                string colElements = Console.ReadLine();
                matrix[row] = colElements.ToCharArray();
            }
        }
        public static void PrintMatrix(char[][] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }
        }
        public static int[] FindParis(char[][] matrix, int matrixSize)
        {
            int[] result = new int[2];

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'P')
                    {
                        result[0] = row;
                        result[1] = col;
                        return result;
                    }
                }
            }
            return null;
        }
        public static bool ValidateIndeces(int row, int col, char[][] matrix, int matrixSize)
        {
            if (row >= 0 && row < matrixSize && col >= 0 && col < matrix[row].Length)
            {
                return true;
            }
            return false;
        }
    }
}
