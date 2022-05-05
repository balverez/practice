public class FirecodeSolution {
  /**
   * Deletes the node at the nth index of the input linked
   * list. If n is out of bounds, returns the list without
   * modification.
   *
   * @param head Head of the singly linked list.
   * @param n    Index (zero-indexed) of the node to be deleted.
   * @return Head ListNode of the modified linked list.
   */
  public ListNode deleteAtIndex(ListNode head, int n) {
    if (n == 0) {
      return head == null ? null : head.next;
    }

    ListNode iterator = head, previous = new ListNode(0, head);
    while (iterator != null && n > 0) {
      previous = iterator;
      iterator = iterator.next;
      n--;
    }
    previous.next = iterator == null ? null : iterator.next;
    return head;
  }
}