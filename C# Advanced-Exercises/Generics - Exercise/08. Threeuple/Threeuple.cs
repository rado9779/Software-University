using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Threeuple
{
    public class Threeuple<T1, T2, T3>
    {

        public T1 TOne { get; set; }

        public T2 TTwo { get; set; }

        public T3 TThree { get; set; }

        public Threeuple(T1 one, T2 two, T3 three)
        {
            this.TOne = one;
            this.TTwo = two;
            this.TThree = three;
        }
        public override string ToString()
        {
            return $"{this.TOne} -> {this.TTwo} -> {this.TThree}";
        }
    }
}
