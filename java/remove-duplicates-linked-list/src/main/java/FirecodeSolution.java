import java.util.HashSet;
import java.util.Set;

public class FirecodeSolution {
  /**
   * Removes duplicates from the passed linked list and
   * returns the head of the modified list.
   *
   * @param head Head of the singly linked list.
   * @return Head ListNode of the modified linked list.
   */
  public ListNode removeDuplicates(ListNode head) {
    Set<Integer> visited = new HashSet<>();
    ListNode iterator = head, previous = null;
    while (iterator != null) {
      if (visited.contains(iterator.data)) {
        previous.next = iterator.next;
      } else {
        previous = iterator;
        visited.add(iterator.data);
      }
      iterator = iterator.next;
    }
    return head;
  }
}