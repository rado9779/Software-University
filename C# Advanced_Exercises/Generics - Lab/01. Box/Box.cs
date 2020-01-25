using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {
            this.Store = new List<T>();
        }

        public List<T> Store { get; set; }

        public int Count => this.Store.Count;

        public void Add(T element)
        {
            this.Store.Add(element);
        }
        public T Remove()
        {
            var element = this.Store[this.Store.Count - 1];
            this.Store.RemoveAt(this.Store.Count - 1);
            return element;
        }

    }
}
