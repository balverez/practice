import java.util.HashSet;
import java.util.Set;

public class Solution {
    /**
     * Removes duplicates from the passed linked list and
     * returns the head of the modified list.
     *
     * @param head Head of the singly linked list.
     * @return Head ListNode of the modified linked list.
     */
    public ListNode removeDuplicates(ListNode head) {
        Set<Integer> dataMap = new HashSet<>();

        ListNode i = new ListNode(0, head);
        ListNode j = head;

        while(j != null)
        {
            if (dataMap.contains(j.data))
            {
                i.next = j.next;
                j = j.next;
            }
            else
            {
                dataMap.add(j.data);
                i = i.next;
                j = j.next;
            }
        }

        return head;
    }
}