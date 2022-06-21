namespace MinCostToConnectAllPoints
{
    public class Solution
    {
        //O(n^2 * logn) time
        //O(n^2) space
        public int MinCostConnectPoints(int[][] points)
        {
            int n = points.Length;
            bool[] span = new bool[n];
            int spanCount = 0;
            PriorityQueue<(int, int), int> minHeap = new();
            minHeap.Enqueue((0, 0), 0);
            int cost = 0;

            //O(n^2 * logn) time
            //O(n^2) space
            while (spanCount < n)
            {
                (int vertex, int weight) = minHeap.Dequeue();
                if (!span[vertex])
                {
                    span[vertex] = true;
                    spanCount++;
                    cost += weight;
                    for (int i = 0; i < n; i++)
                    {
                        if (!span[i])
                        {
                            int dist = ManhattanDistance(points[vertex], points[i]);
                            minHeap.Enqueue((i, dist), dist);
                        }
                    }
                }
            }

            return cost;
        }

        //O(1) time
        //O(1) space
        private int ManhattanDistance(int[] p1, int[] p2) => Math.Abs(p1[0] - p2[0]) + Math.Abs(p1[1] - p2[1]);
    }
}