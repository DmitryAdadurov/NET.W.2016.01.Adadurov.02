using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7.Logic
{
    public class IntInsertion
    {
        /// <summary>
        /// Insert bits of the one integer to another
        /// </summary>
        /// <param name="num1">First integer</param>
        /// <param name="num2">Second integer</param>
        /// <param name="i">"From" position (from right to left)</param>
        /// <param name="j">"To" position (from right to left)</param>
        /// <returns>Resulting integer</returns>
        public static int BitInsertion(int num1, int num2, int i, int j)
        {
            if (i < 0)
                throw new ArgumentOutOfRangeException();

            if (j < 0)
                throw new ArgumentOutOfRangeException();

            if (j < i)
                throw new ArgumentException();

            BitArray b1 = new BitArray(BitConverter.GetBytes(num1));
            BitArray b2 = new BitArray(BitConverter.GetBytes(num2));

            int l = 0;

            for (; i <= j; i++)
            {
                b1[i] = b2[l++];
            }

            int[] array = new int[1];
            b1.CopyTo(array, 0);
            return array[0];
        }
    }
}
