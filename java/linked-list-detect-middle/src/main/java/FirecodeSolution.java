public class FirecodeSolution {
  /**
   * Finds the middle node of the linked list in one pass and returns
   * the data contained within.
   *
   * @param head Head of the singly linked list.
   * @return Data contained within the middle node of the linked list.
   */
  public int findMiddle(ListNode head) {
    ListNode slow = head, fast = head;
    while (fast != null && fast.next != null) {
      slow = slow.next;
      fast = fast.next.next;
    }
    return slow.data;
  }
}
