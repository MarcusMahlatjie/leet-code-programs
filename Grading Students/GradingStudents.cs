using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class GradingStudents
    {
        public static List<int> GradingStudentss(List<int> grades)
        {
            const int roundingThreshold = 3;
            var result = new List<int>();

            foreach (int grade in grades)
            {
                if (grade < 38)
                {
                    result.Add(grade);
                    break;
                }

                int nextMultipleOf5 = (int)Math.Ceiling((double)grade / 5) * 5;

                if (nextMultipleOf5 - grade < roundingThreshold)
                {
                    result.Add(nextMultipleOf5);
                    break;
                }

                //result.Add(grade);
            }

            return result;
        }
    }
}
