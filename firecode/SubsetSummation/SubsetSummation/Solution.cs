using System.Collections.Generic;

namespace SubsetSummation
{
    internal class Solution
    {
        //O(n^2) time
        //O(n) space
        internal bool SubsetSum(int[] arr, int target)
        {
            HashSet<int> set = new();
            HashSet<int> subSet = new();
            set.Add(0);

            foreach (int i in arr)
            {
                subSet = new(set);
                foreach (int j in subSet)
                {
                    set.Add(i + j);
                }
            }

            return set.Contains(target);
        }
    }
}