namespace MeetingRoomsII
{
    public class Solution
    {
        //O(nlogn) time
        //O(nlogn) space
        public int MinMeetingRooms(int[][] intervals)
        {
            Array.Sort(intervals, Comparer<int[]>.Create((int[] x, int[] y) => x[0].CompareTo(y[0])));
            PriorityQueue<int, int> minHeap = new();
            minHeap.Enqueue(intervals[0][1], intervals[0][1]);
            for (int i = 1; i < intervals.Length; i++)
            {
                if (minHeap.Peek() <= intervals[i][0])
                    minHeap.Dequeue();

                minHeap.Enqueue(intervals[i][1], intervals[i][1]);
            }

            return minHeap.Count;
        }
    }
}