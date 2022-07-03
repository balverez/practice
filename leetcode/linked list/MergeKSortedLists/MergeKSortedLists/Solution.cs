namespace MergeKSortedLists
{
    public class Solution
    {
        //O(nlogk) time, where n is number of nodes and k is the number of lists.
        //O(k) space.
        public ListNode? MergeKLists(ListNode?[] lists)
        {
            if (lists.Length == 0)
                return null;
            
            PriorityQueue<ListNode, int> minHeap = new();
            foreach (ListNode? list in lists)
            {
                if (list != null)
                    minHeap.Enqueue(list, list.val);
            }

            ListNode? sentry = new();
            ListNode? i = sentry;
            while (minHeap.Count > 0)
            {
                ListNode list = minHeap.Dequeue();
                i.next = new(list.val);
                i = i.next;
                if (list.next != null)
                    minHeap.Enqueue(list.next, list.next.val);
            }

            return sentry.next;
        }
    }
}