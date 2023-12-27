using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class StringToIntAoti
    {
        public int MyAtoi(string s)
        {
            s = s.Trim();
            if (s.Length == 0) return 0;
            int? negConvert = null;

            double? num = null;
            int place = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (negConvert == null && num == null)
                {
                    if (s[i] == '-')
                    {
                        negConvert = -1;
                        continue;
                    }
                    if (s[i] == '+')
                    {
                        negConvert = 1;
                        continue;
                    }
                }
                if (s[i] < '0' || s[i] > '9') break;
                if (num == null) num = 0;
                num = (num * place) + (s[i] - 48);
                if (place == 1) place *= 10;
            }
            if (negConvert == null) negConvert = 1;
            if (num == null) num = 0;
            if (num * negConvert < int.MinValue) return int.MinValue;
            if (num * negConvert > int.MaxValue) return int.MaxValue;
            return (int)num * (int)negConvert;
        }
    }
}
