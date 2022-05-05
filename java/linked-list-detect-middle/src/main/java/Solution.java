public class Solution {

    /**
     * Finds the middle node of the linked list in one pass and returns
     * the data contained within.
     *
     * @param head Head of the singly linked list.
     * @return Data contained within the middle node of the linked list.
     */
    public int findMiddle(ListNode head) {
        int counter = 1;
        ListNode i = head;

        while (i.next != null)
        {
            i = i.next;
            counter++;
        }

        i = head;
        int limit = counter % 2 == 0 ? (counter / 2) : Math.round((counter / 2));
        while (limit > 0)
        {
            i = i.next;
            limit--;
        }

        return i.data;
    }

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