using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private int[] stones;

        public Lake(IEnumerable<int> stones)
        {
            this.stones = stones.ToArray();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Length; i += 2)
            {
                yield return stones[i];
            }

            var lastOddIndex = this.stones.Length % 2 == 0
               ? this.stones.Length - 1
               : this.stones.Length - 2;

            for (int i = lastOddIndex; i >= 0; i -= 2)
            {
                yield return this.stones[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
