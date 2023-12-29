using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet_code_programs
{
    internal class MaxProfit
    {
        public int MaxProfitOne(int[] prices)
        {
            int max = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > max)
                    {
                        int profit = prices[j] - prices[i];
                        max = Math.Max(profit, max);
                    }
                }
            }

            return max;
        }

        // Second solution with time complexity of O(n) 

        public int MaxProfitTwo(int[] prices)
        {
            if (prices == null || prices.Length < 2)
            {
                return 0; 
            }

            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }

            return maxProfit;
        }

    }
}
