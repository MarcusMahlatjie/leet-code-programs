using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_interview_prep_easy
{
    internal class PlusOne
    {
        public int[] PlusOnee(int[] digits)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int lastElement = digits[digits.Length - 1] + 1;
            if (lastElement > 9)
            {
                //lastElement.Split
            }
            // int lastElement = digits.Last() + 1;
            digits[digits.Length - 1] = lastElement;
          

            return digits;
        }
    }
}
