namespace LinkedListReversal
{
    internal class Solution
    {
        internal ListNode? Reverse(ListNode? head)
        {
            ListNode? nextNode;
            ListNode? previous = null;
            ListNode? iterator = head;
            while (iterator != null)
            {
                nextNode = iterator.Next;
                iterator.Next = previous;
                previous = iterator;
                iterator = nextNode;
            }

            return previous;
        }

        internal ListNode? RecursiveReversal(ListNode current, ListNode? previous)
        {
            ListNode? nextNode = current.Next;
            current.Next = previous;

            if (nextNode != null)
                return RecursiveReversal(nextNode, current);
            else
                return current;
        }
    }
}