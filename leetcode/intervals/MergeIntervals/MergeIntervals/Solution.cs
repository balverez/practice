namespace MergeIntervals
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, Comparer<int[]>.Create((int[] i, int[] j) => i[0].CompareTo(j[0])));

            List<int[]> mergedIntervals = new();
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] > intervals[i - 1][1])
                    mergedIntervals.Add(intervals[i - 1]);
                else
                {
                    intervals[i][0] = Math.Min(intervals[i][0], intervals[i - 1][0]);
                    intervals[i][1] = Math.Max(intervals[i][1], intervals[i - 1][1]);
                }
            }

            mergedIntervals.Add(intervals[intervals.Length - 1]);
            return mergedIntervals.ToArray();
        }
    }
}