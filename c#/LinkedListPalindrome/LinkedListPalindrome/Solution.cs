namespace LinkedListPalindrome
{
    internal class Solution
    {
        internal bool IsPalindrome(ListNode? head)
        {
            ListNode? midpoint = FindMiddle(head);
            ListNode? reversedHalf = Reverse(midpoint);

            while (head != null && reversedHalf != null)
            {
                if (head.Data != reversedHalf.Data)
                    return false;
                head = head.Next;
                reversedHalf = reversedHalf.Next;
            }

            return true;
        }

        internal ListNode? FindMiddle(ListNode? head)
        {
            ListNode? fast = head;
            ListNode? slow = head;

            while(fast?.Next != null)
            {
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            return slow;
        }

        internal ListNode? Reverse(ListNode? head)
        {
            ListNode? previous = null;
            ListNode? next;
            ListNode? iterator = head;
            while (iterator != null)
            {
                next = iterator.Next;
                iterator.Next = previous;
                previous = iterator;
                iterator = next;
            }

            return previous;
        }
    }
}