using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class Reverse
    {
        public int ReverseInt(int x)
        {
            var isNegative = x < 0;

            var xstr = x.ToString().TrimStart('-');
            var segments = xstr.Select(x => x).Reverse();
            var revstr = new string(segments.ToArray());

            int returnval = 0;
            if (int.TryParse(revstr, out returnval))
                if (isNegative) returnval *= -1;

            return returnval;
        }

    }
}