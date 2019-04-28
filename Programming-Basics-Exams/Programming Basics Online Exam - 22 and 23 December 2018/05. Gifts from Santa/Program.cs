using System;

namespace _05._Gifts_from_Santa_pp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());

            for (int i = M ; i >= N; i--)
            {
                if (i % 2 == 0 & i % 3 == 0)
                {
                    if (i != S)
                    {
                        Console.Write(i + " ");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
