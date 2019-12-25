using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];
            byte[,] canAtack = new byte[size, size];
            byte[,] canBeAttacked = new byte[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int counter = 0;

            int[] maxCoordinates = UpdateMatrices(matrix, canAtack, canBeAttacked);

            while (maxCoordinates != null)
            {
                matrix[maxCoordinates[0], maxCoordinates[1]] = '0';
                canAtack = new byte[size, size];
                canBeAttacked = new byte[size, size];
                maxCoordinates = UpdateMatrices(matrix, canAtack, canBeAttacked);
                counter++;
            }

            Console.WriteLine(counter);
        }
        private static int[] UpdateMatrices(char[,] matrix, byte[,] canAtack, byte[,] canBeAttacked)
        {
            int size = matrix.GetLength(0);

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 'K')
                    {
                        if (row > 1)
                        {
                            if (col > 0)
                            {
                                if (matrix[row - 2, col - 1] == 'K')
                                {
                                    canAtack[row, col]++;
                                    canBeAttacked[row - 2, col - 1]++;
                                }
                            }
                            if (col < size - 1)
                            {
                                if (matrix[row - 2, col + 1] == 'K')
                                {
                                    canAtack[row, col]++;
                                    canBeAttacked[row - 2, col + 1]++;
                                }
                            }
                        }
                        if (row < size - 2)
                        {
                            if (col > 0)
                            {
                                if (matrix[row + 2, col - 1] == 'K')
                                {
                                    canAtack[row, col]++;
                                    canBeAttacked[row + 2, col - 1]++;
                                }
                            }
                            if (col < size - 1)
                            {
                                if (matrix[row + 2, col + 1] == 'K')
                                {
                                    canAtack[row, col]++;
                                    canBeAttacked[row + 2, col + 1]++;
                                }
                            }
                        }
                        if (col > 1)
                        {
                            if (row > 0)
                            {
                                if (matrix[row - 1, col - 2] == 'K')
                                {
                                    canAtack[row, col]++;
                                    canBeAttacked[row - 1, col - 2]++;
                                }
                            }

                            if (row < size - 1)
                            {
                                if (matrix[row + 1, col - 2] == 'K')
                                {
                                    canAtack[row, col]++;
                                    canBeAttacked[row + 1, col - 2]++;
                                }
                            }
                        }
                        if (col < size - 2)
                        {
                            if (row > 0)
                            {
                                if (matrix[row - 1, col + 2] == 'K')
                                {
                                    canAtack[row, col]++;
                                    canBeAttacked[row - 1, col + 2]++;
                                }
                            }
                            if (row < size - 1)
                            {
                                if (matrix[row + 1, col + 2] == 'K')
                                {
                                    canAtack[row, col]++;
                                    canBeAttacked[row + 1, col + 2]++;
                                }
                            }
                        }
                    }
                }
            }

            int[] maxCoordinates = null;
            byte maxSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    byte sum = (byte)(canAtack[row, col] + canBeAttacked[row, col]);

                    if (sum > maxSum)
                    {
                        maxCoordinates = new int[] { row, col };
                        maxSum = sum;
                    }
                }
            }

            return maxCoordinates;
        }
        private static void PrintMatrix(byte[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
