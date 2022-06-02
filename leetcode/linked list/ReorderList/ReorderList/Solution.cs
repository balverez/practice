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
            ListNode? previous = null;
            ListNode? next = null;
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
            ListNode sentinel = new(int.MinValue);
            ListNode iterator = sentinel;

            bool headFlag = true;
            while (head != null && reversedHalf != null)
            {
                if (headFlag)
                {
                    iterator.next = head;
                    head = head.next;
                    headFlag = false;
                }
                else
                {
                    iterator.next = reversedHalf;
                    reversedHalf = reversedHalf.next;
                    headFlag = true;
                }

                iterator = iterator.next;
            }
        }
    }
}