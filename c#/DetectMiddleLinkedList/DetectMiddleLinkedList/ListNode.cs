using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectMiddleLinkedList
{
    internal class ListNode
    {
        public int Data { get; set; }
        public ListNode? Next { get; set; }

        public ListNode(int data, ListNode next)
        {
            Data = data;
            Next = next;
        }

        public ListNode(int data)
        {
            Data = data;
        }
    }
}
