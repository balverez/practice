using System;

namespace MaxSubArraySum
{
    internal class Solution
    {
        public int MaxSum(int[] arr, int k)
        {
            int maxSum = int.MinValue;

            int sum = 0;
            int tail = 0;
            for (int head = 0; head < arr.Length; head++)
            {
                sum += arr[head];

                if (head - tail + 1 == k)
                {
                    maxSum = Math.Max(maxSum, sum);
                    sum -= arr[tail++];
                }
            }

            return maxSum;
        }
    }
}
