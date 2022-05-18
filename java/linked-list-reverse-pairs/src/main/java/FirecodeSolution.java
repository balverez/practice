public class FirecodeSolution {
  /**
   * Reverses the list in pairs in place and returns the
   * head of the modified list.
   *
   * @param head Head ListNode.
   * @return Head ListNode of the modified list.
   */
  public ListNode reverseInPairs(ListNode head) {
    ListNode dummyHead = new ListNode(-1);
    dummyHead.next = head;
    ListNode prev = dummyHead;
    while (head != null && head.next != null) {
      ListNode first = head, second = head.next;

      prev.next = second;
      first.next = second.next;
      second.next = first;

      prev = first;
      head = first.next;
    }

    return dummyHead.next;
  }
}