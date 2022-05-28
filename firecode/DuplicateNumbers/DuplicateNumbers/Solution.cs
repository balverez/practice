using System.Collections.Generic;
using System.Linq;

namespace DuplicateNumbers
{
    public class Solution
    {
        public int[] FindDuplicateNumbers(int[] arr)
        {
            HashSet<int> set = new();
            SortedSet<int> sortedSet = new();

            foreach (int i in arr)
            {
                if (set.Contains(i))
                    sortedSet.Add(i);
                
                set.Add(i);
            }

            return sortedSet.ToArray();
        }
    }
}
