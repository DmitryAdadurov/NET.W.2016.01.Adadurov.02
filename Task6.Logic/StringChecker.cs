using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Logic
{
    public class StringChecker
    {
        public static string RemoveRepeatedCharacters(string str)
        {

            StringBuilder sb = new StringBuilder(str.Length);

            foreach (var item in str.ToArray().GroupBy(t => t))
            {
                sb.Append(item.Key);
            }

            return SortCharsInString(sb.ToString());
        }

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
