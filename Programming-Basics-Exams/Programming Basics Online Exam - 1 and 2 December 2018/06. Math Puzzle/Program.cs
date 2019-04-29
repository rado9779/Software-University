using System;

namespace _06._Math_Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            bool combination = false;

            for (int firstNum = 1; firstNum <= 30; firstNum++)
            {
                for (int secondNum = 1; secondNum <= 30; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <= 30; thirdNum++)
                    {
                        if (firstNum < secondNum && secondNum < thirdNum)
                        {
                            if (firstNum + secondNum + thirdNum == key)
                            {
                                Console.WriteLine($"{firstNum} + {secondNum} + {thirdNum} = {key}");
                                combination = true;
                            }
                        }
                        if (firstNum > secondNum && secondNum > thirdNum)
                        {
                            if (firstNum * secondNum * thirdNum == key)
                            {
                                Console.WriteLine($"{firstNum} * {secondNum} * {thirdNum} = {key}");
                                combination = true;
                            }
                        }
                    }
                }
            }
            if (combination == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
