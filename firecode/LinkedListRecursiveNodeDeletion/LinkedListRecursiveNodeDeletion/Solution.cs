namespace LinkedListRecursiveNodeDeletion
{
    internal class Solution
    {
        internal ListNode? DeleteAtIndex(ListNode? head, int n)
        {
            if (head == null)
                return head;

            if (--n < 0)
            {
                return head.Next;
            }

            head.Next = DeleteAtIndex(head.Next, n);
            return head;
        }
    }
}