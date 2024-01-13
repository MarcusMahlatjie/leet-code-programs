using System;

namespace Program
{
   public class Solution {
        public int LengthOfLastWord(string s) 
        {
            string[] arr = s.Split(" ");
            string lastWord = String.Empty;
            int count = arr.Length - 1;

            if (arr.Length == 1)
            {
                return arr[0].Length;
            }

            while (count >= 0)
            {
                if (arr[count] != "" & count >= 0)
                {
                    lastWord = arr[count];
                    return lastWord.Length;
                }

                else 
                {
                    count--;
                }
            }

            return lastWord.Length;
        }
    }

}