using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInsertTail
{
    internal class Solution
    {
        public ListNode InsertTail(ListNode? head, int n)
        {
            ListNode newNode = new(n);

            if (head == null)
                return newNode;

            ListNode tail = GetTail(head);
            tail.Next = newNode;

            return head;
        }

        private ListNode GetTail(ListNode head)
        {
            ListNode i = head;

            while (i.Next != null)
                i = i.Next;

            return i;
        }
    }   
}
