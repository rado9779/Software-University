using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
    public class Box<T>
    {
        public Box()
        {
            this.Data = new List<T>();
        }

        public List<T> Data { get; set; }

        public void Add(T value)
        {
            this.Data.Add(value);
        }
    }
}
