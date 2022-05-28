using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListInsertHead
{
    internal class Solution
    {
        public DoublyLinkedListNode InsertHead(DoublyLinkedListNode? head, int n)
        {
            DoublyLinkedListNode newHead = new(n);

            if (head != null)
            {
                head.Previous = newHead;
                newHead.Next = head;
            }

            return newHead;
        }
    }
}
