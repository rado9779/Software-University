using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] triangle = new long[rows][];
            int currentCol = 1;

            for (int row = 0; row < rows; row++)
            {
                triangle[row] = new long[currentCol];
                long[] currentRow = triangle[row];

                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                currentCol++;

                if (currentRow.Length > 2)
                {
                    for (int i = 1; i < currentRow.Length - 1; i++)
                    {
                        long[] previousRow = triangle[row - 1];
                        long prevoiousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = prevoiousRowSum;
                    }
                }

            }
            foreach (long[] matrixRow in triangle)
            {
                Console.WriteLine(string.Join(" ", matrixRow));
            }
        }
    }
}
