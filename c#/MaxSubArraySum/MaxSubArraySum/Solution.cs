using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubArraySum
{
    internal class Solution
    {
        public int MaxSum(int[] arr, int k)
        {
            int maxSum = 0;
            int windowSum = 0;
            int tail = 0;

            for (int head = 0; head < arr.Length; head++)
            {
                windowSum += arr[head];

                if ((head - tail + 1) == k)
                {
                    maxSum = Math.Max(maxSum, windowSum);
                    windowSum -= arr[tail++];
                }
            }

            return maxSum;
        }
    }
}
