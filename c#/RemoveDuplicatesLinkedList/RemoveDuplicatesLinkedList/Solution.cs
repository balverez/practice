using System.Collections.Generic;

namespace RemoveDuplicatesLinkedList
{
    internal class Solution
    {
        public ListNode RemoveDuplicates(ListNode head)
        {
            HashSet<int> occurences = new();
            ListNode previous = head;
            ListNode? iterator = head;
            while (iterator != null)
            {
                if (occurences.Contains(iterator.Data))
                {
                    previous.Next = iterator.Next;
                    iterator = iterator.Next;
                }
                else
                {
                    occurences.Add(iterator.Data);
                    previous = iterator;
                    iterator = iterator.Next;
                }
            }

            return head;
        }
    }
}
