using System.Collections.Generic;

namespace LinkedListMergeSorted
{
    internal class Solution
    {
        internal ListNode? MergeLists(List<List<int>> lists)
        {
            ListNode result = new(int.MaxValue);
            PriorityQueue<ListNode, int> minHeap = new();
            
            foreach (List<int> list in lists)
                foreach (int i in list)
                    minHeap.Enqueue(new(i), i);

            ListNode iterator = result;
            while (minHeap.Count > 0)
            {
                iterator.Next = minHeap.Dequeue();
                iterator = iterator.Next;
            }

            return result.Next;
        }
    }
}