public class Solution {
    /**
     * Reverses the passed singly linked list.
     *
     * @param head Head ListNode of the list.
     * @return Head ListNode of the reversed list.
     */
    public ListNode reverseList(ListNode head)
    {
        ListNode tmp = null;
        ListNode i = null;
        ListNode j = head;

        while (j != null)
        {
            tmp = j.next;
            j.next = i;
            i = j;
            j = tmp; 
        }

        return i;
    }
}
