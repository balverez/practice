public class FirecodeSolution {
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
    DoubleLinkListNode sentinelNode =
      new DoubleLinkListNode(Integer.MIN_VALUE, null, head);
    DoubleLinkListNode previous = sentinelNode;
    while (--i >= 0 && previous.next != null) {
      previous = previous.next;
    }
    DoubleLinkListNode newNode =
      new DoubleLinkListNode(n, previous, previous.next);
    previous.next = newNode;
    if (newNode.next != null) {
      newNode.next.previous = newNode;
    }
    return sentinelNode.next;
  }
}