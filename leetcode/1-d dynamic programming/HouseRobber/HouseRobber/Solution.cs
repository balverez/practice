namespace HouseRobber
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);

            nums[1] = Math.Max(nums[0], nums[1]);
            int robbed = 0;
            for (int i = 2; i < nums.Length; i++)
            {
                robbed = Math.Max(nums[i] + nums[i - 2], nums[i - 1]);
                nums[i] = robbed;
            }

            return robbed;
        }
    }
}