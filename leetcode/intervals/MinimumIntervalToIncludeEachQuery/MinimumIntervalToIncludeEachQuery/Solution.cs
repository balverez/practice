namespace MinimumIntervalToIncludeEachQuery
{
    public class Solution
    {
        //O(nlogn + mlogm) time, where n is the number of queries and m is the number of intervals.
        //O(n + m) time, where n is the number of queries and m is the number of intervals.
        public int[] MinInterval(int[][] intervals, int[] queries)
        {
            //O(n) time
            //O(n) space
            int[] answers = new int[queries.Length];
            Array.Fill(answers, -1);

            //O(mlogm) time
            //O(m) space
            Array.Sort(intervals, Comparer<int[]>.Create((int[] x, int[] y) => x[0].CompareTo(y[0])));
            PriorityQueue<(int, int), (int, int)> intervalHeap = new();

            //O(nlogn) time
            //O(n) space
            PriorityQueue<(int, int), int> queryHeap = new();
            for (int i = 0; i < queries.Length; i++)
                queryHeap.Enqueue((queries[i], i), queries[i]);

            //O(n + mlogm) time
            int j = 0;
            while (queryHeap.Count > 0)
            {
                (int q, int i) = queryHeap.Peek();
                while (j < intervals.Length && intervals[j][0] <= q)
                {
                    int range = intervals[j][1] - intervals[j][0] + 1;
                    intervalHeap.Enqueue((range, intervals[j][1]), (range, intervals[j][1]));
                    j++;
                }

                while (intervalHeap.Count > 0 && intervalHeap.Peek().Item2 < q)
                    intervalHeap.Dequeue();

                if (intervalHeap.Count > 0)
                    answers[i] = intervalHeap.Peek().Item1;

                queryHeap.Dequeue();
            }

            return answers;
        }
    }
}