namespace LinkedListReversePairs
{
    internal class Solution
    {
        internal ListNode? ReverseInPairs(ListNode head)
        {
            ListNode newHead = new(-1, head);
            ListNode? iterator = head;
            ListNode? i;
            ListNode? j;
            ListNode? previous = newHead;

            while (iterator != null && iterator.Next != null)
            {
                i = iterator;
                j = iterator.Next;
                previous.Next = j;
                i.Next = j.Next;
                j.Next = i;

                previous = i;
                iterator = i.Next;
            }

            return newHead.Next;
        }
    }
}