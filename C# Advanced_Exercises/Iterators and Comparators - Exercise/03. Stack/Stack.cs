using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] array;
        private int index;

        public Stack(int initialCapacity = 4)
        {
            this.array = new T[initialCapacity];
            this.index = 0;
        }
        public void Push(T element)
        {
            if (index == array.Length)
            {
                DoubleCapacity();
            }
            array[index++] = element;
        }
        public T Pop()
        {
            if (index == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            return array[--index];
        }
        private void DoubleCapacity()
        {
            T[] newArr = new T[array.Length * 2];
            Array.Copy(array, newArr, array.Length);
            array = newArr;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (var i = index - 1; i >= 0; i--)
            {
                yield return array[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
