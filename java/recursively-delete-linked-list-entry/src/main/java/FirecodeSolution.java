public class FirecodeSolution {
  /**
   * Recursively deletes the node at the nth index of the input linked
   * list. If n is out of bounds, returns the list without
   * modification.
   *
   * @param head Head of the singly linked list.
   * @param n    Index (zero-indexed) of the node to be deleted.
   * @return Head ListNode of the modified linked list.
   */
  public ListNode deleteAtIndex(ListNode head, int n) {
    if (head == null) {
      return null;
    } else if (n == 0) {
      return head.next;
    }
    head.next = deleteAtIndex(head.next, n - 1);
    return head;
  }
}