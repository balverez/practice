using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsert
{
    internal class Solution
    {
        public ListNode Insert(ListNode head, int n, int i)
        {
            ListNode sentinel = new ListNode(int.MinValue, head);
            ListNode iterator = sentinel;

            while (--i >= 0 && iterator.Next != null)
                iterator = iterator.Next;

            iterator.Next = new ListNode(n, iterator.Next);

            return sentinel.Next;
        }
    }
}
