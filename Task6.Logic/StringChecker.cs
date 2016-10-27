using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Logic
{
    public class StringChecker
    {
        /// <summary>
        /// Removes repeting characters from the string
        /// </summary>
        /// <param name="str">String with repeated characters</param>
        /// <returns>String without repeated characters</returns>
        public static string RemoveRepeatedCharacters(string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            if (str == String.Empty)
                return String.Empty;

            StringBuilder sb = new StringBuilder(str.Length);

            foreach (var item in str.ToArray().GroupBy(t => t))
            {
                if (item.Key <= 'z' && item.Key >= 'a')
                {
                    sb.Append(item.Key);
                }
            }

            return SortCharsInString(sb.ToString());
        }


        /// <summary>
        /// Sort chars in the string
        /// </summary>
        /// <param name="str">String with chars to sort</param>
        /// <returns>String with sorted characters</returns>
        public static string SortCharsInString(string str)
        {
            StringBuilder sb = new StringBuilder(str);

            for (int i = 0; i < sb.Length - 1; i++)
            {
                for (int j = i; j < sb.Length; j++)
                {
                    if (sb[i] > sb[j])
                    {
                        char temp = sb[i];
                        sb[i] = sb[j];
                        sb[j] = temp;
                    }
                }
            }

            return sb.ToString();
        }

    }
}
