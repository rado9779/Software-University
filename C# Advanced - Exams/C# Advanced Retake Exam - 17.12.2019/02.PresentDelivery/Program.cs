using System;
using System.Linq;

namespace _02.PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int presents = int.Parse(Console.ReadLine());
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];
            FillMatrix(matrix, matrixSize);

            int[] santaPosition = FindSanta(matrix, matrixSize);
            int santaRow = santaPosition[0];
            int santaCol = santaPosition[1];

            int happyKids = 0;


            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Christmas morning")
                {
                    break;
                }
                matrix[santaRow, santaCol] = '-';

                switch (command)
                {
                    case "up":
                        santaRow--;
                        break;
                    case "down":
                        santaRow++;
                        break;
                    case "left":
                        santaCol--;
                        break;
                    case "right":
                        santaCol++;
                        break;
                }

                if (matrix[santaRow, santaCol] == 'V')
                {
                    presents--;
                    matrix[santaRow, santaCol] = '-';
                    happyKids++;
                }
                else if (matrix[santaRow, santaCol] == 'X')
                {
                    matrix[santaRow, santaCol] = '-';
                }
                else if (matrix[santaRow, santaCol] == 'C')
                {
                    matrix[santaRow, santaCol] = '-';
                    if (matrix[santaRow - 1,santaCol] == 'V' || )
                    {

                    }

                }
                matrix[santaRow, santaCol] = 'S';
                if (presents == 0)
                {
                    Console.WriteLine("Santa ran out of presents!");
                    break;
                }
                if (KidsWithoutPresent(matrix, matrixSize) == 0)
                {
                    break;
                }
            }

            PrintMatrix(matrix, matrixSize);
            if (KidsWithoutPresent(matrix, matrixSize) == 0)
            {
                Console.WriteLine($"Good job, Santa! {happyKids} happy nice kid/s.");
            }
            else
            {
                int kids = KidsWithoutPresent(matrix, matrixSize);
                Console.WriteLine($"No presents for {kids} nice kid/s.");
            }

        }
        public static void FillMatrix(char[,] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                char[] colElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }
        public static void PrintMatrix(char[,] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[] FindSanta(char[,] matrix, int matrixSize)
        {
            int[] coordinates = new int[2];

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                    }
                }
            }
            return coordinates;
        }
        public static int KidsWithoutPresent(char[,] matrix, int matrixSize)
        {
            int kids = 0;

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == 'V')
                    {
                        kids++;
                    }
                }
            }
            return kids;
        }
        public static bool GivePresent(int row, int col, char[,] matrix)
        {
            if (matrix[row, col] == 'C' || matrix[row, col] == 'X')
            {
                return true;
            }
            return false;
        }
    }
}
