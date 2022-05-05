using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivelyDeleteLinkedListEntry
{
    internal class Solution
    {
        public ListNode? DeleteAtIndex(ListNode? head, int n)
        {
            if (head == null)
                return null;
            else if (n == 0)
                return head.Next;

            head.Next = DeleteAtIndex(head.Next, --n);
            return head;
        }
    }
}
