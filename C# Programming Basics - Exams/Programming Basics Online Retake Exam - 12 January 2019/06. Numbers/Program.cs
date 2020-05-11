using System;
using System.Linq;

namespace _06._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string number = n.ToString();

            int rows = int.Parse(number[0].ToString()) + int.Parse(number[1].ToString());
            int colums = int.Parse(number[0].ToString()) + int.Parse(number[2].ToString());

            string result = "";


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - int.Parse(number[0].ToString());
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - int.Parse(number[1].ToString());
                    }
                    else
                    {
                        n = n + int.Parse(number[2].ToString());
                    }
                    result += $"{n} ";
                }
                Console.WriteLine(result);
                result = "";
            }
        }
    }
}
