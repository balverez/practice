namespace InsertInterval
{
    internal class Solution
    {
        //O(n) time
        //O(n) space
        internal int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> result = new();

            foreach (int[] interval in intervals)
            {
                if (newInterval[1] < interval[0])
                {
                    result.Add(newInterval);
                    newInterval = interval;
                }
                else if (interval[1] < newInterval[0])
                {
                    result.Add(interval);
                }
                else
                {
                    newInterval[0] = Math.Min(newInterval[0], interval[0]);
                    newInterval[1] = Math.Max(newInterval[1], interval[1]);
                }
            }

            result.Add(newInterval);

            return result.ToArray();
        }
    }
}