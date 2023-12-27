using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class MedianTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedArr = new int[nums1.Length + nums2.Length];
            var list = new List<int>();
            list.AddRange(nums1);
            list.AddRange(nums2);
            mergedArr = list.ToArray();
            double median = 0;

            if (mergedArr.Length % 2 == 0)
            {
                median = mergedArr[mergedArr.Length / 2];
            }

            else
            {
                median = (nums1.Last() + nums2.Last()) / 2; 
            }

            return median;
        }
    }
}
