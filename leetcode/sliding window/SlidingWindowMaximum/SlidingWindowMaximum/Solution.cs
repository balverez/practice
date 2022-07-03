namespace SlidingWindowMaximum
{
    public class Solution
    {
        //O(n) time
        //O(n) space
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 1 || k == 1)
                return nums;

            int[] maximums = new int[nums.Length - k + 1];
            LinkedList<int> list = new();
            list.AddFirst(nums[0]);
            int tail = 0;
            int head;
            for (head = 1; head < nums.Length; head++)
            {
                while (list.Last?.Value < nums[head])
                    list.RemoveLast();
                
                list.AddLast(nums[head]);
                if (head - tail + 1 == k)
                {
                    maximums[tail] = list.First.Value;
                    if (nums[tail++] == list.First.Value)
                        list.RemoveFirst();
                }
            }

            return maximums;
        }
    }
}