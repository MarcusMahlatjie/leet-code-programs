using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            int goal = nums.Length - 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (i + nums[i] >= goal)
                {
                    if (i == 0)
                    {
                        return true;
                    }
                    goal = i;
                }
            }
            return false;
        }
    }
}
