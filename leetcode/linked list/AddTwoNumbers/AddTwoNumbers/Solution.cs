namespace AddTwoNumbers
{
    //O(max(m, n)) time
    //O(1) space
    public class Solution
    {
        public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
        {
            ListNode sentry = new(int.MinValue);
            ListNode? newNumber = sentry;
            int sum = 0;

            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                newNumber.next = new(sum % 10);
                newNumber = newNumber.next;
                sum = sum > 9 ? 1 : 0;
            }

            if (sum > 0)
                newNumber.next = new(sum);

            return sentry.next;
        }
    }
}