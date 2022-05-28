using System.Collections.Generic;

namespace TwoSum
{
    internal class Solution
    {
        internal int[] TwoSum(int[] arr, int target)
        {
            Dictionary<int, int> valueIndexMap = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (valueIndexMap.ContainsKey(arr[i]))
                    return new int[] { valueIndexMap[arr[i]], i };

                valueIndexMap[target - arr[i]] = i;
            }

            return new int[] { };
        }
    }
}