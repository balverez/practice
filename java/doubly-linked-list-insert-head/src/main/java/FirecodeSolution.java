public class FirecodeSolution {
  /**
   * Inserts a new DoubleLinkListNode with data n at the head of the doubly
   * linked list, given the head of the list.
   *
   * @param head Head of the doubly linked list.
   * @param n    Integer to set on the data property of the inserted node.
   * @return Head DoubleLinkListNode of the modified double linked list.
   */
  public DoubleLinkListNode insertAtHead(DoubleLinkListNode head, int n) {
    DoubleLinkListNode newNode = new DoubleLinkListNode(n);
    if (head == null) {
      return newNode;
    } else {
      newNode.next = head;
      head.previous = newNode;
    }
    return newNode;
  }
}