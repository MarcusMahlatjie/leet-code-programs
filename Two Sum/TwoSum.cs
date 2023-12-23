using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class TwoSum
    {
        public int[] TwoSumm(int[] nums, int target)
        {
            int[] ans = new int[2];
            int ans1 = 0;
            int ans2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = 0; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == target)
                    {
                        if (k != i)
                        {
                            ans1 = k;
                            ans2 = i;
                            break;
                        }
                    }
                }
            }

            ans[0] = ans1;
            ans[1] = ans2;

            return ans;
        }
    }
}
