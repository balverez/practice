namespace KClosestPointsToOrigin
{
    public class Solution
    {
        //O(nlogn) time
        //O(n) space
        public int[][] KClosest(int[][] points, int k)
        {
            PriorityQueue<int, double> minHeap = new();

            for (int i = 0; i < points.Length; i++)
            {
                int[] point = points[i];
                double distance = EuclideanDistance(point[0], point[1]);
                minHeap.Enqueue(i, distance);
            }

            List<int[]> closest = new();

            while (k > 0)
            {
                closest.Add(points[minHeap.Dequeue()]);
                k--;
            }

            return closest.ToArray();
        }

        private double EuclideanDistance(int a, int b) => Math.Sqrt((a * a) + (b * b));
    }
}