namespace MergeTwoLinkedLists
{
    public class Solution
    {
        //O(n * m) time
        //O(1) space
        public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            ListNode sentinel = new(int.MinValue);

            ListNode iterator = sentinel;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    iterator.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    iterator.next = list2;
                    list2 = list2.next;
                }

                iterator = iterator.next;
            }

            iterator.next = list1 != null ? list1 : list2;

            return sentinel.next;
        }
    }
}