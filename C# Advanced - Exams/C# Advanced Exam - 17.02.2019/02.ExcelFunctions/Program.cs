using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.ExcelFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int tableSize = int.Parse(Console.ReadLine());
            string[][] table = new string[tableSize][];

            for (int row = 0; row < tableSize; row++)
            {
                string[] rowValues = Console.ReadLine()
                    .Split(", ");

                table[row] = rowValues;
            }

            string[] line = Console.ReadLine()
                .Split();

            string command = line[0];
            string header = line[1];

            int headerIndex = Array.IndexOf(table[0], header);

            if (command == "hide")
            {

                for (int row = 0; row < table.Length; row++)
                {
                    List<string> lineToPrint = new List<string>(table[row]);

                    lineToPrint.RemoveAt(headerIndex);
                    Console.WriteLine(string.Join(" | ", lineToPrint));

                    table[row] = lineToPrint.ToArray();
                }
            }
            else if (command == "sort")
            {
                string[] headerRow = table[0];

                Console.WriteLine(string.Join(" | ", headerRow));

                table = table.OrderBy(x => x[headerIndex]).ToArray();

                foreach (var row in table)
                {
                    if (row != headerRow)
                    {
                        Console.WriteLine(string.Join(" | ", row));
                    }
                }
            }
            else if (command == "filter")
            {
                string parameter = line[2];
                string[] headerRow = table[0];

                Console.WriteLine(string.Join(" | ", headerRow));

                for (int i = 0; i < table.Length; i++)
                {
                    if (table[i][headerIndex] == parameter)
                    {
                        Console.WriteLine(string.Join(" | ", table[i]));
                    }
                }
            }
        }
    }
}
