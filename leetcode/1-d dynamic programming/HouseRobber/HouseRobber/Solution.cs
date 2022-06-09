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

            int robbed = 0;
            int twoBack = 0;
            int oneBack = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                robbed = Math.Max(oneBack, twoBack + nums[i]);
                twoBack = oneBack;
                oneBack = robbed;
            }

            return robbed;
        }
    }
}