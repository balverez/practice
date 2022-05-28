using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListInsertNode
{
    internal class Solution
    {
        public DoublyLinkedListNode? Insert(DoublyLinkedListNode? head, int n, int i)
        {
            if (head == null)
                return new DoublyLinkedListNode(n, null, null);

            DoublyLinkedListNode sentinel = new(int.MinValue, null, head);
            DoublyLinkedListNode? iterator = sentinel;

            while (--i >= 0 && iterator.Next != null)
                iterator = iterator.Next;

            iterator.Next = new DoublyLinkedListNode(n, iterator, iterator.Next);
            if (iterator.Next.Next != null)
                iterator.Next.Previous = iterator.Next;

            return sentinel.Next;
        }
    }
}
