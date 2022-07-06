namespace FindMedianFromDataStream
{
    //O(n) space
    public class MedianFinder
    {
        PriorityQueue<int, int> LeftPartition { get; set; } = new(Comparer<int>.Create((int x, int y) => y.CompareTo(x)));
        PriorityQueue<int, int> RightPartition { get; set; } = new();

        //O(logn) time
        public void AddNum(int num)
        {
            LeftPartition.Enqueue(num, num);
            if (LeftPartition.Count > RightPartition.Count + 1)
            {
                int data = LeftPartition.Dequeue();
                RightPartition.Enqueue(data, data);
            }
            else if (RightPartition.Count > 0 && LeftPartition.Peek() > RightPartition.Peek())
            {
                int rightMin = RightPartition.Dequeue();
                int leftMax = LeftPartition.Dequeue();
                LeftPartition.Enqueue(rightMin, rightMin);
                RightPartition.Enqueue(leftMax, leftMax);
            }
        }

        //O(1) time
        public double FindMedian() => (LeftPartition.Count + RightPartition.Count) % 2 == 0
            ? (double)(LeftPartition.Peek() + RightPartition.Peek()) / 2
            : LeftPartition.Peek();
    }
}