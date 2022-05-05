using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArrayAverages
{
    internal class Solution
    {
        public double[] Averages(int[] arr, int k)
        {
            double[] averages = new double[arr.Length - k + 1];
            double windowSum = 0D;
            int tail = 0;

            for (int head = 0; head < arr.Length; head++)
            {
                windowSum += arr[head];
                if ((head - tail + 1) == k)
                {
                    averages[tail] = windowSum / k;
                    windowSum -= arr[tail++];
                }
            }

            return averages;
        }
    }
}
