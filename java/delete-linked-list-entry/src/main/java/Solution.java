public class Solution {
    /**
     * Deletes the node at the nth index of the input linked
     * list. If n is out of bounds, returns the list without
     * modification.
     *
     * @param head Head of the singly linked list.
     * @param n    Index (zero-indexed) of the node to be deleted.
     * @return Head ListNode of the modified linked list.
     */
    public ListNode deleteAtIndex(ListNode head, int n)
    {
        ListNode i = head;
        while (i != null && i.next != null)
        {
            n--;
            if (n == 0)
            {
                i.next = i.next.next;
                break;
            }
            else if (n < 0)
            {
                head = i.next;
                break;
            }

            i = i.next;
        }

        return head;
    }
  }