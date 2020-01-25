using System;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());

            int intial = target - 30;
            int jumpCounter = 0;
            int currentTry = 0;
            int currentJump = 0;

            while (true)
            {
                for (currentTry = 1; currentTry <= 3; currentTry++)
                {
                    currentJump = int.Parse(Console.ReadLine());
                    jumpCounter++;

                    if (currentJump > intial)
                    {
                        if (intial >= target)
                        {
                            Console.WriteLine($"Tihomir succeeded, he jumped over {target}cm after {jumpCounter} jumps.");
                            return;
                        }

                        intial += 5;
                        break;
                    }
                }
                if (currentTry == 4)
                {
                    Console.WriteLine($"Tihomir failed at {intial}cm after {jumpCounter} jumps.");
                    return;
                }
            }
        }
    }
}
