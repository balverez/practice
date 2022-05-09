using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPalindrome
{
    internal class Solution
    {
        public bool IsPalindorme(ListNode? head)
        {
            if (head == null)
                return true;

            ListNode? middle = FindMiddle(head);

            ListNode? firstHalf = head;
            ListNode? reversedSecondHalf = Reverse(middle);

            while (firstHalf != null && reversedSecondHalf != null)
            {
                if (firstHalf.Data != reversedSecondHalf.Data)
                    return false;

                firstHalf = firstHalf.Next;
                reversedSecondHalf = reversedSecondHalf.Next;
            }

            return true;
        }

        private ListNode? FindMiddle(ListNode? head)
        {
            ListNode? slow = head;
            ListNode? fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow?.Next;
                fast = fast.Next.Next;
            }

            return slow;
        }

        private ListNode? Reverse(ListNode? head)
        {
            ListNode? next;
            ListNode? previous = null;
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
