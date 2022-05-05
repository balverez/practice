public class FirecodeSolution {
  /**
   * Checks if the input list is a palindrome
   *
   * @param head Head ListNode of the list.
   * @return True if the list is a palindrome.
   */
  public Boolean isPalindrome(ListNode head) {
    ListNode middleNode = getMiddle(head);
    ListNode reversedListHead = reverseList(middleNode);
    ListNode forwardListHead = head;
    while (forwardListHead != null && reversedListHead != null) {
      if (forwardListHead.data != reversedListHead.data) return false;
      forwardListHead = forwardListHead.next;
      reversedListHead = reversedListHead.next;
    }
    return true;
  }

  private ListNode reverseList(ListNode head) {
    ListNode iterator = head, previous = null;
    while (iterator != null) {
      ListNode nextNode = iterator.next;
      iterator.next = previous;
      previous = iterator;
      iterator = nextNode;
    }
    return previous;
  }

  private ListNode getMiddle(ListNode head) {
    ListNode slow = head;
    ListNode fast = head;
    while (fast != null && fast.next != null) {
      slow = slow.next;
      fast = fast.next.next;
    }
    return slow;
  }
}