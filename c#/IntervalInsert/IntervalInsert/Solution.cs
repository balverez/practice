using System;
using System.Collections.Generic;

namespace IntervalInsert
{
    internal class Solution
    {
        public List<List<int>> InsertInterval(List<List<int>> intervals, List<int> insert)
        {
            List<List<int>> result = new();

            foreach (List<int> interval in intervals)
            {
                if (interval[1] < insert[0])
                    result.Add(interval);
                else if (insert[1] < interval[0])
                {
                    result.Add(insert);
                    insert = interval;
                }
                else
                {
                    insert[0] = Math.Min(insert[0], interval[0]);
                    insert[1] = Math.Max(insert[1], interval[1]);
                }
            }

            result.Add(insert);
            return result;
        }
    }
}