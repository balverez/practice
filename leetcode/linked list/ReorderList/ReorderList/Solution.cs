namespace ReorderList
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public void ReorderList(ListNode? head)
        {
            ListNode? middle = FindMiddle(head);
            ListNode? reversedHalf = Reverse(middle);
            MergeTwoLists(head, reversedHalf);
        }

        //O(n) time
        //O(1) space
        private ListNode? FindMiddle(ListNode? head)
        {
            ListNode? fast = head;
            ListNode? slow = head;
            while (fast?.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            return slow;
        }

        //O(n) time
        //O(1) space
        private ListNode? Reverse(ListNode? head)
        {
            ListNode? next;
            ListNode? previous = null;
            ListNode? iterator = head;

            while (iterator != null)
            {
                next = iterator.next;
                iterator.next = previous;
                previous = iterator;
                iterator = next;
            }

            return previous;
        }

        //O(n) time
        //O(1) space
        private void MergeTwoLists(ListNode? head, ListNode? reversedHalf)
        {
            ListNode? iterator = head;
            while (reversedHalf.next != null)
            {
                ListNode? temp = iterator.next;
                iterator.next = reversedHalf;
                iterator = temp;
                temp = reversedHalf.next;
                reversedHalf.next = iterator;
                reversedHalf = temp;
            }
        }
    }
}