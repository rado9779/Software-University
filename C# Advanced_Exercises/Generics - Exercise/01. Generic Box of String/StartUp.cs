﻿using System;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();

                Box<string> box = new Box<string>(line);

                Console.WriteLine(box);
            }

        }
    }
}
