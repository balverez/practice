namespace CarFleet
{
    public class Solution
    {
        //O(nlogn) time
        //O(n) space
        public int CarFleet(int target, int[] position, int[] speed)
        {
            int n = position.Length;
            if (n == 1)
                return 1;

            PriorityQueue<int, int> pq = new(Comparer<int>.Create((int x, int y) => y.CompareTo(x)));
            for (int i = 0; i < n; i++)
                pq.Enqueue(i, position[i]);

            int count = 0;
            double ahead = double.MinValue;
            while (pq.Count > 0)
            {
                int car = pq.Dequeue();
                double targetTime = (double)(target - position[car]) / speed[car];
                if (targetTime <= ahead)
                    continue;

                ahead = targetTime;
                count++;
            }

            return count;
        }
    }
}