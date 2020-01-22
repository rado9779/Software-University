using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> word = new List<char>(Console.ReadLine());

            int fieldSize = int.Parse(Console.ReadLine());

            int[,] field = new int[fieldSize, fieldSize];

            int playerRow = 0;
            int playerCol = 0;

            FillMatrix(field, fieldSize);

            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                int row = playerRow;
                int col = playerCol;

                switch (command)
                {
                    case "up":
                        row--;
                        break;
                    case "down":
                        row++;
                        break;
                    case "left":
                        col--;
                        break;
                    case "right":
                        col++;
                        break;
                }
                if (isValidIndex(row, col, field, fieldSize))
                {
                    if (char.IsLetter((char)field[row, col]))
                    {
                        word.Add((char)field[row, col]);
                    }

                    field[playerRow, playerCol] = '-';
                    playerRow = row;
                    playerCol = col;
                    field[playerRow, playerCol] = 'P';
                }
                else
                {
                    word.RemoveAt(word.Count - 1);
                }

            }

            for (int i = 0; i < word.Count; i++)
            {
                Console.Write(word[i]);
            }
            Console.WriteLine();
            PrintMatrix(field, fieldSize);

        }
        public static void FillMatrix(int[,] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                string colElements = Console.ReadLine();

                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
        }
        public static void PrintMatrix(int[,] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write((char)matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        public static bool isValidIndex(int row, int col, int[,] matrix, int matrixSize)
        {
            if (row >= 0 && row < matrixSize && col >= 0 && col < matrixSize)
            {
                return true;
            }
            return false;
        }
    }
}
