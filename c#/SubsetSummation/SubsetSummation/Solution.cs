using System.Collections.Generic;

namespace SubsetSummation
{
    internal class Solution
    {
        //O(n^2) time
        internal bool SubsetSum(int[] arr, int target)
        {
            HashSet<int> set = new();
            set.Add(0);

            foreach (int i in arr)
            {
                HashSet<int> subset = new(set);
                foreach(int j in subset)
                    set.Add(i + j);
            }

            return set.Contains(target);
        }
    }
}