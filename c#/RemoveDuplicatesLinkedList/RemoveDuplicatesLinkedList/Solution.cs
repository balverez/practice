using System.Collections.Generic;

namespace RemoveDuplicatesLinkedList
{
    internal class Solution
    {
        public ListNode RemoveDuplicates(ListNode head)
        {
            HashSet<int> dataMap = new HashSet<int>();

            ListNode? i = new(0, head);
            ListNode? j = head;

            while (j != null)
            {
                if (dataMap.Contains(j.Data))
                    i.Next = j.Next;
                else
                {
                    i = j;
                    dataMap.Add(j.Data);
                }

                j = j.Next;
            }

            return head;
        }
    }
}
