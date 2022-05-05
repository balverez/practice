using System.Collections.Generic;
using System.Linq;

namespace DuplicateNumbers
{
    public class Solution
    {
        public int[] FindDuplicateNumbers(int[] testArr)
        {
            SortedSet<int> sortedSet = new SortedSet<int>();
            HashSet<int> vistedSet = new HashSet<int>();

            testArr.ToList().ForEach(n =>
            {
                if (vistedSet.Contains(n))
                    sortedSet.Add(n);

                vistedSet.Add(n);
            });

            return sortedSet.ToArray();
        }
    }
}
