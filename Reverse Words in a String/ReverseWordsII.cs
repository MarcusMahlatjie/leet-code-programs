using System;

namespace Program {
    public class Solution {
        // O(1) TIME COMPLEXITY SOLUTION
        public string ReverseWords(string s) 
        {
            string[] newString = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Array.Reverse(newString);
            return string.Join(" ", newString).Trim();
        }
    }
}