using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            StringBuilder subStr = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (subStr.Length > 0)
                    {
                        if (!subStr.ToString().Contains(s[j]))
                        {
                            subStr.Append(s[j]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        subStr.Append(s[j]);
                    }
                }

                if (subStr.Length > maxLength)
                    maxLength = subStr.Length;

                subStr = new StringBuilder();
            }

            return maxLength;

        }
    }
}
