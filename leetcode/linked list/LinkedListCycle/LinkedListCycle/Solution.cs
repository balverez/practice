namespace LinkedListCycle
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public bool HasCycle(ListNode? head)
        {
            int offset = 200001;
            while (head != null)
            {
                if (head.val <= -offset)
                    return true;

                head.val -= offset;
                head = head.next;
            }

            return false;
        }
    }
}