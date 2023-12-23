using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_interview_prep_easy
{
    internal class RemoveDuplicates
    {
        public int RemoveDuplicatess(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int k = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
