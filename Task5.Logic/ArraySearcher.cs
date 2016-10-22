using System;

namespace Task5.Logic
{
    public class ArraySearcher
    {
        public static int? LeftRightEqualIndex(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (array.Length < 3)
                throw new ArgumentException("Array too short");

            for (int i = 1; i < array.Length; i++)
            {
                int sumLeft = 0, sumRight = 0;

                for (int j = 0; j < i; j++)
                {
                    sumLeft += array[j];
                }

                for (int j = i + 1; j < array.Length; j++)
                {
                    sumRight += array[j];
                }

                if (sumLeft == sumRight)
                {
                    return i;
                }

            }

            return null;
        }
    }


}
