public class FirecodeSolution {
  /**
   * Deletes the node at the nth index of the input doubly linked
   * list. If n is out of bounds, returns the list without
   * modification.
   *
   * @param head Head of the doubly linked list.
   * @param n    Index (zero-indexed) of the node to be deleted.
   * @return Head DoubleLinkListNode of the modified linked list.
   */
  public DoubleLinkListNode deleteAtIndex(DoubleLinkListNode head, int n) {
    DoubleLinkListNode sentinelNode =
      new DoubleLinkListNode(Integer.MIN_VALUE, null, head);
    DoubleLinkListNode previous = sentinelNode;
    while (--n >= 0 && previous.next != null) {
      previous = previous.next;
    }
    if (previous.next != null) {
      previous.next = previous.next.next;
      if (previous.next != null) {
        previous.next.previous = previous;
      }
    }
    return sentinelNode.next;
  }
}