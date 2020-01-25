using System;

namespace _03.SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int galaxySize = int.Parse(Console.ReadLine());

            char[,] galaxy = new char[galaxySize, galaxySize];

            FillMatrix(galaxy, galaxySize);

            int[] spaceshipPositions = FindSpaceship(galaxy, galaxySize);

            int spaceshipRow = spaceshipPositions[0];
            int spaceshipCol = spaceshipPositions[1];

            int starPower = 0;

            while (true)
            {
                galaxy[spaceshipRow, spaceshipCol] = '-';
                string command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                        spaceshipRow--;
                        break;
                    case "down":
                        spaceshipRow++;
                        break;
                    case "left":
                        spaceshipCol--;
                        break;
                    case "right":
                        spaceshipCol++;
                        break;
                }

                if (ValidateIndexes(spaceshipRow, spaceshipCol, galaxySize) == false)
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    break;
                }
                else
                {
                    if (char.IsDigit(galaxy[spaceshipRow, spaceshipCol]))
                    {
                        starPower += int.Parse(galaxy[spaceshipRow, spaceshipCol].ToString());
                        galaxy[spaceshipRow, spaceshipCol] = '-';
                        if (starPower >= 50)
                        {
                            galaxy[spaceshipRow, spaceshipCol] = 'S';
                            Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                            break;
                        }
                    }
                    else if (galaxy[spaceshipRow, spaceshipCol] == 'O')
                    {
                        galaxy[spaceshipRow, spaceshipCol] = '-';
                        int[] teleportPosition = FindBlackHole(galaxy, galaxySize);

                        spaceshipRow = teleportPosition[0];
                        spaceshipCol = teleportPosition[1];
                    }
                }
            }

            Console.WriteLine($"Star power collected: {starPower}");
            PrintMatrix(galaxy, galaxySize);

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
        public static int[] FindSpaceship(char[,] matrix, int matrixSize)
        {
            int[] result = new int[2];

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        result[0] = row;
                        result[1] = col;
                    }
                }
            }
            return result;
        }
        public static bool ValidateIndexes(int row, int col, int matrixSize)
        {
            if (row >= 0 && row < matrixSize && col >= 0 && col < matrixSize)
            {
                return true;
            }
            return false;
        }
        public static int[] FindBlackHole(char[,] matrix, int matrixSize)
        {
            int[] result = new int[2];

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (matrix[row, col] == 'O')
                    {
                        result[0] = row;
                        result[1] = col;
                    }
                }
            }
            return result;
        }
    }
}
