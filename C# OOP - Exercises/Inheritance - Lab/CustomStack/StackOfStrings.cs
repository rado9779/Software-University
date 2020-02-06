﻿using System.Collections.Generic;

namespace CustomStack
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }
        public void AddRange(Stack<string> stack)
        {
            foreach (var element in stack)
            {
                this.Push(element);
            }
        }
    }
}
