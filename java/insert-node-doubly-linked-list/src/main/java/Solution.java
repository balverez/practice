public class Solution {
    /**
     * Inserts a new DoubleLinkListNode with data n at the specified i and
     * returns the head of the modified list.
     *
     * @param head Head of the doubly linked list.
     * @param n    Integer to set on the data property of the inserted node.
     * @param i    Zero indexed integer position to insert the new node.
     * @return Head DoubleLinkListNode of the modified doubly linked list.
     */
    public DoubleLinkListNode insertAtIndex(DoubleLinkListNode head, int n, int i) {
        DoubleLinkListNode sentinel = new DoubleLinkListNode(Integer.MIN_VALUE, null, head);
        DoubleLinkListNode iterator = sentinel;

        while (--i >= 0 && iterator.next != null)
        {
            iterator = iterator.next;
        }

        iterator.next = new DoubleLinkListNode(n, iterator, iterator.next);
        DoubleLinkListNode newNode = iterator.next;
        if (newNode.next != null)
        {
            newNode.next.previous = newNode;
        }

        return sentinel.next;
    }
}
