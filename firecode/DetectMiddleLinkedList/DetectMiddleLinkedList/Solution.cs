using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectMiddleLinkedList
{
    internal class Solution
    {
        public int FindMiddle(ListNode head)
        {
            ListNode? slow = head;
            ListNode? fast = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow?.Next;
                fast = fast.Next.Next;
            }

            return slow.Data;
        }
    }
}
