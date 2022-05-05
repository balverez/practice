public class Solution
{
    /**
     * Checks if the input list is a palindrome
     *
     * @param head Head ListNode of the list.
     * @return True if the list is a palindrome.
     */
    public Boolean isPalindrome(ListNode head)
    {
        if (head == null)
        {
            return true;
        }

        ListNode middle = findMiddle(head);

        ListNode reversedHalf = reverse(middle);
        ListNode firstHalf = head;

        while (firstHalf != null && reversedHalf != null)
        {
            if (firstHalf.data != reversedHalf.data)
            {
                return false;
            }

            firstHalf = firstHalf.next;
            reversedHalf = reversedHalf.next;
        }

        return true;
    }

    private ListNode findMiddle(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }

    private ListNode reverse(ListNode head)
    {
        ListNode iterator = head;
        ListNode previous = null;
        while (iterator != null)
        {
            ListNode next = iterator.next;
            iterator.next = previous;
            previous = iterator;
            iterator = next;
        }

        return previous;
    }
}