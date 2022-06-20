namespace NonOverlappingIntervals
{
    public class Solution
    {
        //O(nlogn) time
        //O(1) space
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, Comparer<int[]>.Create((int[] x, int[] y) => x[0].CompareTo(y[0])));
            int[] insert = intervals[0];
            int count = 0;
            for (int i = 1; i < intervals.Length; i++)
            {
                if (insert[1] <= intervals[i][0])
                    insert = intervals[i];
                else if (insert[0] >= intervals[i][1])
                    continue;
                else
                {
                    insert[1] = Math.Min(insert[1], intervals[i][1]);
                    count++;
                }
            }

            return count;
        }
    }
}