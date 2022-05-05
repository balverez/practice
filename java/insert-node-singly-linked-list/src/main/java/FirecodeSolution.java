public class FirecodeSolution {
    /**
     * Inserts a new ListNode with data n to the tail of the singly linked list,
     * given the head of the list.
     *
     * @param head Head of the singly linked list.
     * @param n    Integer to set on the data property of the inserted node.
     * @return Head ListNode of the modified linked list
     */
    public ListNode insertAtEnd(ListNode head, int n) {
      ListNode newNode = new ListNode(n);
      if (head == null) {
        return newNode;
      }
      ListNode tailNode = getTailNode(head);
      tailNode.next = newNode;
      return head;
    }
  
  
    /**
     * Traverses to the end of a singly linked list and returns its last node
     *
     * @param head Head of the singly linked list
     * @return The last node of the passed linked list
     */
    private ListNode getTailNode(ListNode head) {
      ListNode iterator = head;
      while (iterator.next != null) {
        iterator = iterator.next;
      }
      return iterator;
    }
  }