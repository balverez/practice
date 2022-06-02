namespace LastStoneWeight
{
    public class Solution
    {
        //O(nlogn) time
        //O(n) space
        public int LastStoneWeight(int[] stones)
        {
            PriorityQueue<int, int> maxHeap = new(Comparer<int>.Create((int x, int y) => y.CompareTo(x)));

            foreach (int i in stones)
                maxHeap.Enqueue(i, i);

            while (maxHeap.Count > 1)
            {
                int firstStone = maxHeap.Dequeue();
                int secondStone = maxHeap.Dequeue();

                if (firstStone != secondStone)
                {
                    firstStone -= secondStone;
                    maxHeap.Enqueue(firstStone, firstStone);
                }
            }

            return maxHeap.Count > 0 ? maxHeap.Dequeue() : 0;
        }
    }
}