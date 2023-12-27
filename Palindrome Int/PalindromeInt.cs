using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class PalindromeInt
    {
        public bool IsPalindrome(int x)
        {
            string xArr = x.ToString();
            int i = 0;
            int j = (xArr.Length - 1);

            while (i < j)
            {
                if (xArr[i] != xArr[j])
                {
                    return false;
                }
                i++;
                j--;
            }

            return true;
        }
    }
}
