namespace ReverseLinkedList
{
    public class Solution
    {
        //O(n) time
        //O(1) space
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