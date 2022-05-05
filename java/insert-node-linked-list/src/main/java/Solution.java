public class Solution {
    /**
     * Inserts a new ListNode with data n at the specified i and
     * returns the head of the modified list.
     *
     * @param head Head of the singly linked list.
     * @param n    Integer to set on the data property of the inserted node.
     * @param i    Zero indexed integer position to insert the new node.
     * @return Head ListNode of the modified linked list.
     */
    public ListNode insertAtIndex(ListNode head, int n, int i)
    {
        if (i == 0 || head == null)
        {
            return new ListNode(n, head);
        }

        ListNode previous = null;
        ListNode iterator = head;

        while (iterator != null && i != 0)
        {
            i--;
            previous = iterator;
            iterator = iterator.next;
        }

        ListNode newNode = new ListNode(n, iterator);
        previous.next = newNode;

        return head;
    }
}