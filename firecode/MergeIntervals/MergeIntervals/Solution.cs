using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeIntervals
{
    internal class Solution
    {
        public List<List<int>> MergeIntervals(List<List<int>> intervals)
        {
            intervals.Sort(delegate(List<int> x, List<int> y)
            {
                return x[0].CompareTo(y[0]);
            });

            List<List<int>> result = new();

            foreach(List<int> interval in intervals)
            {
                if (result.Count == 0 || result.Last()[1] < interval[0])
                    result.Add(interval);
                else
                    result.Last()[1] = Math.Max(result.Last()[1], interval[1]);
            }

            return result;
        }
    }
}
