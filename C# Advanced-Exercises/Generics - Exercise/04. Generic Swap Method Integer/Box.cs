using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {
        public Box()
        {
            this.Values = new List<T>();
        }

        public List<T> Values { get; set; }

        public int Count => this.Values.Count;

        public void Add(T data)
        {
            this.Values.Add(data);
        }
    }
}
