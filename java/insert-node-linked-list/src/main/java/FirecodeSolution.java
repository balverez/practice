public class FirecodeSolution {
  /**
   * Inserts a new ListNode with data n at the specified i and
   * returns the head of the modified list.
   *
   * @param head Head of the singly linked list.
   * @param n    Integer to set on the data property of the inserted node.
   * @param i    Zero indexed integer position to insert the new node.
   * @return Head ListNode of the modified linked list.
   */
  public ListNode insertAtIndex(ListNode head, int n, int i) {
    ListNode sentinelNode = new ListNode(Integer.MIN_VALUE, head);
    ListNode previous = sentinelNode;
    while (--i >= 0 && previous.next != null) {
      previous = previous.next;
    }
    previous.next = new ListNode(n, previous.next);
    return sentinelNode.next;
  }
}