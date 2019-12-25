using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] matrix = new double[n][];

            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Select(double.Parse)
                     .ToArray();
            }

            for (int row = 0; row < n - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(x => x * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(x => x / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x / 2).ToArray();
                }
            }


            while (true)
            {
                string[] line = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = line[0];

                if (command == "End")
                {
                    PrintMatrix(matrix, n);
                    break;
                }

                int row = int.Parse(line[1]);
                int col = int.Parse(line[2]);
                int value = int.Parse(line[3]);

                if (command == "Add")
                {
                    if (ValidateIndexes(matrix,row,col,n))
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (command == "Subtract")
                {
                    if (ValidateIndexes(matrix,row,col,n))
                    {
                        matrix[row][col] -= value;
                    }
                }



            }
        }
        public static bool ValidateIndexes(double[][] matrix,int row,int col,int n)
        {
            if (row >= 0 && row < n && col >= 0 && col < matrix[row].Length)
            {
                return true;
            }

            return false;
        }
        public static void PrintMatrix(double[][] matrix,int n)
        {
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ",matrix[row]));
            }
        }
    }
}
