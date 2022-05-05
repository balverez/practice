using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListInsertHead
{
    internal class Solution
    {
        public DoublyLinkedListNode InsertHead(DoublyLinkedListNode? root, int n)
        {
            DoublyLinkedListNode result = new(n);
            if (root == null)
                return new(n);

            result.Next = root;
            root.Previous = result;
            return result;
        }
    }
}
