namespace ReverseNodesInKGroup
{
    public class Solution
    {
        public ListNode? ReverseKGroup(ListNode head, int k)
        {
            ListNode? sentry = new(int.MinValue, head);
            ListNode? prevGroup = sentry;
            while (true)
            {
                ListNode? kth = GetKth(prevGroup, k);
                if (kth == null)
                    break;

                ListNode? nextGroup = kth.next;
                ListNode? prev = kth.next;
                ListNode? groupHead = prevGroup.next;
                while (groupHead != nextGroup)
                {
                    ListNode? next = groupHead.next;
                    groupHead.next = prev;
                    prev = groupHead;
                    groupHead = next;
                }

                ListNode? newGroup = prevGroup.next;
                prevGroup.next = kth;
                prevGroup = newGroup;
            }

            return sentry?.next;
        }

        private ListNode? GetKth(ListNode? curr, int k)
        {
            while (curr != null && k > 0)
            {
                curr = curr.next;
                k--;
            }

            return curr;
        }
    }
}