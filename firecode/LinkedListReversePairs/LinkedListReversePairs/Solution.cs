namespace LinkedListReversePairs
{
    internal class Solution
    {
        internal ListNode? ReversePairs(ListNode? head)
        {
            ListNode sentinel = new(int.MinValue, head);
            ListNode previous = sentinel;
            ListNode? i;
            ListNode j;

            while (head != null && head.Next != null)
            {
                i = head;
                j = head.Next;
                i.Next = j.Next;
                j.Next = i;
                previous.Next = j;
                previous = i;
                head = i.Next;
            }

            return sentinel.Next;
        }
    }
}