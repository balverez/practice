using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteLinkedListEntry
{
    internal class Solution
    {
        public ListNode? DeleteAtIndex(ListNode head, int n)
        {
            if (n == 0)
                return head?.Next;

            ListNode? i = head;
            n--;
            while (i != null && n > 0)
            {
                i = i.Next;
                n--;
            }

            if (i != null)
            {
                i.Next = i.Next?.Next;
            }

            return head;
        }
    }
}
