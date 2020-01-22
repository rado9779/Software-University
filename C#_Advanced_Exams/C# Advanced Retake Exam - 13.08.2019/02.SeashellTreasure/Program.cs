using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SeashellTreasure
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> collectedSeashells = new List<char>();
            int stolenSeashells = 0;

            int beachSize = int.Parse(Console.ReadLine());

            char[][] beach = new char[beachSize][];

            FillMatrix(beach, beachSize);

            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = line[0];

                if (command == "Sunset")
                {
                    break;
                }

                int row = int.Parse(line[1]);
                int col = int.Parse(line[2]);

                if (ValidateCoordinates(row, col, beach) == false)
                {
                    continue;
                }

                if (command == "Collect")
                {
                    if (beach[row][col] != '-')
                    {
                        collectedSeashells.Add(beach[row][col]);
                        beach[row][col] = '-';
                    }
                }
                else if (command == "Steal")
                {
                    string direction = line[3];

                    if (direction == "up")
                    {
                        for (int i = row; i >= row - 3; i--)
                        {
                            if (ValidateCoordinates(i, col, beach) == true && beach[i][col] != '-')
                            {
                                stolenSeashells++;
                                beach[i][col] = '-';
                            }
                        }
                    }
                    else if (direction == "down")
                    {
                        for (int i = row; i <= row + 3; i++)
                        {
                            if (ValidateCoordinates(i, col, beach) == true && beach[i][col] != '-')
                            {
                                stolenSeashells++;
                                beach[i][col] = '-';
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int i = col; i >= col - 3; i--)
                        {
                            if (ValidateCoordinates(row, i, beach) == true && beach[row][i] != '-')
                            {
                                stolenSeashells++;
                                beach[row][i] = '-';
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = col; i <= beach[row].Length; i++)
                        {
                            if (ValidateCoordinates(row, i, beach) == true && beach[row][i] != '-')
                            {
                                stolenSeashells++;
                                beach[row][i] = '-';
                            }
                        }
                    }
                }
            }

            PrintMatrix(beach);
            PrintFinalResult(collectedSeashells, stolenSeashells);
        }
        public static void FillMatrix(char[][] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                char[] colElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                matrix[row] = colElements;
            }
        }
        public static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
        public static bool ValidateCoordinates(int row, int col, char[][] matrix)
        {
            if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
            {
                return true;
            }
            return false;
        }
        public static void PrintFinalResult(List<char> collected, int stolen)
        {
            if (collected.Count > 0)
            {
                Console.Write($"Collected seashells: {collected.Count} -> ");
                Console.Write(string.Join(", ", collected));
                Console.WriteLine();
                Console.WriteLine($"Stolen seashells: {stolen}");
            }
            else
            {
                Console.WriteLine($"Collected seashells: {collected.Count}");
                Console.WriteLine($"Stolen seashells: {stolen}");
            }
        }
    }
}
