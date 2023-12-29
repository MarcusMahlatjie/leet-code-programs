using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class MajorityElement
    {
        public class Solution
        {
            public int MajorityElement(int[] nums)
            {
                List<int> numbers = nums.ToList();
                numbers.Sort();
                int check = 0;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (numbers[i + 1] == numbers[i])
                    {
                        check++;
                    }
                    else
                    {
                        check = 0;
                    }
                    if (check >= nums.Length / 2)
                    {
                        return numbers[i];
                    }
                }
                return numbers[0];
            }
        }
    }
}
