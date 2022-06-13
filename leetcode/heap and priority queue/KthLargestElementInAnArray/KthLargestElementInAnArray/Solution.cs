namespace KthLargestElementInAnArray
{
    public class Solution
    {
        //O(nlogk) time
        //O(k) space
        public int FindKthLargest(int[] nums, int k)
        {
            PriorityQueue<int, int> pq = new();
            foreach (int i in nums)
            {
                pq.Enqueue(i, i);
                if (pq.Count > k)
                    pq.Dequeue();
            }

            return pq.Peek();
        }
    }
}