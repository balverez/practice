namespace ReverseLinkedList
{
    public class Solution
    {
        public ListNode? ReverseList(ListNode? head)
        {
            ListNode? previous = null;
            ListNode? next;
            while (head != null)
            {
                next = head.next;
                head.next = previous;
                previous = head;
                head = next;
            }

            return previous;
        }
    }
}