using System;

namespace _02.TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];
            FillMatrix(matrix, matrixSize);

            int[] firstPlayerPosition = FindPlayer(matrix, matrixSize, 'f');
            int firstPlayerRow = firstPlayerPosition[0];
            int firstPlayerCol = firstPlayerPosition[1];

            int[] secondPlayerPosition = FindPlayer(matrix, matrixSize, 's');
            int secondPlayerRow = secondPlayerPosition[0];
            int secondPlayerCol = secondPlayerPosition[1];

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = commands[0];
                string secondCommand = commands[1];

                matrix[firstPlayerRow, firstPlayerCol] = 'f';
                matrix[secondPlayerRow, secondPlayerCol] = 's';

                if (firstCommand == "up")
                {
                    firstPlayerRow--;
                    if (firstPlayerRow < 0)
                    {
                        firstPlayerRow = matrixSize - 1;
                    }
                    if (FirstPlayerGo(matrix, firstPlayerRow, firstPlayerCol) == true)
                    {
                        break;
                    }
                }
                else if (firstCommand == "down")
                {
                    firstPlayerRow++;
                    if (firstPlayerRow >= matrixSize)
                    {
                        firstPlayerRow = 0;
                    }
                    if (FirstPlayerGo(matrix, firstPlayerRow, firstPlayerCol) == true)
                    {
                        break;
                    }
                }
                else if (firstCommand == "left")
                {
                    firstPlayerCol--;
                    if (firstPlayerCol < 0)
                    {
                        firstPlayerCol = matrixSize - 1;
                    }
                    if (FirstPlayerGo(matrix, firstPlayerRow, firstPlayerCol) == true)
                    {
                        break;
                    }
                }
                else if (firstCommand == "right")
                {
                    firstPlayerCol++;
                    if (firstPlayerCol >= matrixSize)
                    {
                        firstPlayerCol = 0;
                    }
                    if (FirstPlayerGo(matrix, firstPlayerRow, firstPlayerCol) == true)
                    {
                        break;
                    }
                }
                //second
                if (secondCommand == "up")
                {
                    secondPlayerRow--;
                    if (secondPlayerRow < 0)
                    {
                        secondPlayerRow = matrixSize - 1;
                    }
                    if (SecondPlayerGo(matrix, secondPlayerRow, secondPlayerCol) == true)
                    {
                        break;
                    }
                }
                else if (secondCommand == "down")
                {
                    secondPlayerRow++;
                    if (secondPlayerRow >= matrixSize)
                    {
                        secondPlayerRow = 0;
                    }
                    if (SecondPlayerGo(matrix, secondPlayerRow, secondPlayerCol) == true)
                    {
                        break;
                    }
                }
                else if (secondCommand == "left")
                {
                    secondPlayerCol--;
                    if (secondPlayerCol < 0)
                    {
                        secondPlayerCol = matrixSize - 1;
                    }
                    if (SecondPlayerGo(matrix, secondPlayerRow, secondPlayerCol) == true)
                    {
                        break;
                    }
                }
                else if (secondCommand == "right")
                {
                    secondPlayerCol++;
                    if (secondPlayerCol >= matrixSize)
                    {
                        secondPlayerCol = 0;
                    }
                    if (SecondPlayerGo(matrix, secondPlayerRow, secondPlayerCol) == true)
                    {
                        break;
                    }
                }

            }

            PrintMatrix(matrix, matrixSize);

        }
        public static void FillMatrix(char[,] matrix, int matrixSize)
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
        public static void PrintMatrix(char[,] matrix, int matrixSize)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        public static int[] FindPlayer(char[,] matrix, int matrixSize, char playerSymbol)
        {
            int[] playerCoordinates = new int[2];

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == playerSymbol)
                    {
                        playerCoordinates[0] = row;
                        playerCoordinates[1] = col;
                    }
                }
            }
            return playerCoordinates;
        }
        public static bool FirstPlayerGo(char[,] matrix,int row, int col)
        {
            if (matrix[row,col] == 's')
            {
                matrix[row, col] = 'x';
            }
            return true;
        }
        public static bool SecondPlayerGo(char[,] matrix, int row, int col)
        {
            if (matrix[row, col] == 'f')
            {
                matrix[row, col] = 'x';
            }
            return true;
        }
    }
}
