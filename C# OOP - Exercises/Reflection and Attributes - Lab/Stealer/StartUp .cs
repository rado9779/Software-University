﻿using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();

            //string result = spy.StealFieldInfo("Stealer.Hacker","username","password");
            //string result = spy.AnalyzeAcessModifers("Stealer.Hacker");
            //string result = spy.RevealPrivateMethods("Stealer.Hacker");
            string result = spy.CollectGettersAndSetters("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }
}
