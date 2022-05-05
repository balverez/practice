public class FirecodeSolution {
  /**
   * Reverses the passed singly linked list.
   *
   * @param head Head ListNode of the list.
   * @return Head ListNode of the reversed list.
   */
  public ListNode reverseList(ListNode head) {
    ListNode iterator = head, previous = null;
    while (iterator != null) {
      ListNode nextNode = iterator.next;
      iterator.next = previous;
      previous = iterator;
      iterator = nextNode;
    }
    return previous;
  }
}