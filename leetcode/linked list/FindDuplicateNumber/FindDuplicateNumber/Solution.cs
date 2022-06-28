namespace FindDuplicateNumber
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int FindDuplicate(int[] nums)
        {
            int fast = nums[0];
            int slow = nums[0];

            while (true)
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
                if (fast == slow)
                    break;
            }

            slow = nums[0];

            while (fast != slow)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return fast;
        }
    }
}