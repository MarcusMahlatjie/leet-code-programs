using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_interview_prep_easy
{
    internal class Duplicates
    {
        public bool ContainsDuplicate(int[] nums)
        {
            bool hasDuplicate = false;
            Array.Sort(nums);

            for (int i = 1;  i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    hasDuplicate = true;
                    break;
                }
            }

            return hasDuplicate;
        }
    }
}
