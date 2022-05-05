using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
    internal class Solution
    {
        public ListNode? Reverse(ListNode? head)
        {
            ListNode? temp;
            ListNode? i = null;
            ListNode? j = head;

            while(j != null)
            {
                temp = j.Next;
                j.Next = i;
                i = j;
                j = temp;
            }

            return i;
        }
    }
}
