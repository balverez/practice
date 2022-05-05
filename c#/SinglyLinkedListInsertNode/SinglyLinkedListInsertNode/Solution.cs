using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedListInsertNode
{
    public class Solution
    {
        public static ListNode InsertAtEnd(ListNode? head, int n)
        {
            ListNode newNode = new(n);
            if (head == null)
            {
                return newNode;
            }

            ListNode tailNode = GetTailNode(head);
            tailNode.Next = newNode;

            return head;
        }

        private static ListNode GetTailNode(ListNode head)
        {
            ListNode i = head;
            
            while (i.Next != null)
            {
                i = i.Next;
            }

            return i;
        }
    }
}
