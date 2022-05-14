using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Solution
    {
        public static int[] TwoSum(int[] arr, int target)
        {
            Dictionary<int, int> candidates = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (candidates.ContainsKey(arr[i]))
                    return new int[] { candidates[arr[i]], i };
                else
                    candidates[target - arr[i]] = i;
            }

            return new int[] { };
        }
    }
}
