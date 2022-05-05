using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Solution
    {
        public int[] TwoSum(int[] arr, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                    return new int[] { map[arr[i]], i };
                else
                    map[target - arr[i]] = i;
            }

            return new int[] { };
        }
    }
}
