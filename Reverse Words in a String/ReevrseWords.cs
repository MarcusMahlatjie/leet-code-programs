using System;

namespace Program {
    public class Solution {
        // There are ways to do this with a constant time complexity, but I think using built in methods defies 
        // the challenge of algorithms but included in this folder is the solution wiht a constant time complexity
        public string ReverseWords(string s) 
        {
            string[] str = s.Split(" ");           
            string[] finalArray = new string[str.Length];
            string final = string.Empty;
            int j = 0; int count = 0;
            Array.Reverse(str);

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != "" && str[i] != " ")
                {
                    finalArray[j]= str[i];                    
                    j++;
                    count++;
                }
                
            }

            for(int i = 0;i< count; i++)
            {
                if(i == count-1)
                {
                    final = final + finalArray[i];
                }
                else 
                {
                    final = final + finalArray[i]+" ";
                }
                
            }
            return final;
        }
    }
}