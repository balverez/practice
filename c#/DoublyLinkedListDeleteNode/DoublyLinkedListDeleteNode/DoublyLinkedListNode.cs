using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListDeleteNode
{
    public class DoublyLinkedListNode
    {
        public int Data { get; set; }
        public DoublyLinkedListNode? Previous { get; set; }
        public DoublyLinkedListNode? Next { get; set; }

        public DoublyLinkedListNode(int data, DoublyLinkedListNode? previous, DoublyLinkedListNode? next)
        {
            Data = data;
            Previous = previous;
            Next = next;
        }

        public DoublyLinkedListNode(int data)
        {
            Data = data;
            Previous = null;
            Next = null;
        }
    }
}
