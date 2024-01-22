﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms.my_practice
{
    internal class FizzBuzzz
    {
        public string[] FizzBuzz(int n)
        {
            string[] arr = new string[n];

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    arr[i - 1] = "FizzBuzz";
                }

                else if (i % 3 == 0)
                {
                    arr[i - 1] = "Fizz";
                }

                else if (i % 5 == 0)
                {
                    arr[i - 1] = "Buzz";
                }

                else
                {
                    arr[i - 1] = i.ToString();
                }
            }

            return arr;
        }
    }
}
