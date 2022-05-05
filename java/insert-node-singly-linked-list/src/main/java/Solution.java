public class Solution {
    /**
     * Inserts a new ListNode with data n to the tail of the singly linked list,
     * given the head of the list.
     *
     * @param head Head of the singly linked list.
     * @param n    Integer to set on the data property of the inserted node.
     * @return Head ListNode of the modified linked list
     */
    public static ListNode insertAtEnd(ListNode head, int n) {
        if (head != null)
        {
            ListNode newNode = new ListNode(n);

            ListNode i = head;
            while (i.next != null) {
                i = i.next;
            }
    
            i.next = newNode;
        }
        else
        {
            head = new ListNode(n);
        }

        return head;
    }

}