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
        public static int BitInsertion(int num1, int num2, int i, int j)
        {
            BitArray b1 = new BitArray(BitConverter.GetBytes(num1));
            BitArray b2 = new BitArray(BitConverter.GetBytes(num2));

            int l = 31;

            for (; i <= j; i++)
            {
                b1[i] = b2[l--];
            }

            int[] array = new int[1];
            b1.CopyTo(array, 0);
            return array[0];
        }
    }
}
