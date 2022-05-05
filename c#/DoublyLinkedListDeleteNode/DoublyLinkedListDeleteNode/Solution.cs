using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListDeleteNode
{
    internal class Solution
    {
        public DoublyLinkedListNode? Delete(DoublyLinkedListNode head, int i)
        {
            DoublyLinkedListNode sentinel = new(int.MinValue, null, head);
            DoublyLinkedListNode iterator = sentinel;

            while (--i >= 0 && iterator.Next != null)
                iterator = iterator.Next;

            if (iterator.Next != null)
            {
                iterator.Next = iterator.Next.Next;

                if (iterator.Next != null)
                    iterator.Next.Previous = iterator;
            }

            return sentinel.Next;
        }
    }
}
