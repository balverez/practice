namespace RemoveNthNodeFromEndOfList
{
    //O(n) time
    //O(1) space
    public class Solution
    {
        //O(n) time
        //O(1) space
        public ListNode? RemoveNthFromEnd(ListNode? head, int n)
        {
            ListNode sentinel = new(int.MinValue, head);
            ListNode? first = sentinel;
            ListNode? second = sentinel;
            for (int i = 0; i < n + 1; i++)
                first = first.next;

            while (first != null)
            {
                first = first.next;
                second = second.next;
            }

            second.next = second.next.next;
            return sentinel.next;
        }
    }
}