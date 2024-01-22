using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.my_practice
{
    internal class Anagram
    {
        public bool isAnagram(string a, string b)
        {
            char[] charsA = a.ToCharArray();
            char[] charsB = a.ToCharArray();

            Array.Sort(charsA);
            Array.Sort(charsB);

            string x = charsA.ToString();
            string y = charsA.ToString();

            if (x == y)
            {
                return true;
            }

            return false;
        }
    }
}
