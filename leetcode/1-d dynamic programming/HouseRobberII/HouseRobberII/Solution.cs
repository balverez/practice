namespace HouseRobberII
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int Rob(int[] nums)
        {
            int n = nums.Length;
            if (n < 2)
                return nums[0];
            if (n == 2)
                return Math.Max(nums[0], nums[1]);

            return Math.Max(RobNeighborhood(0, n - 1, nums), RobNeighborhood(1, n, nums));
        }

        private int RobNeighborhood(int start, int n, int[] nums)
        {
            if (n - start < 2)
                return nums[start];
            if (n - start == 2)
                return Math.Max(nums[start], nums[start + 1]);

            int robbed = 0;
            int twoBack = 0;
            int oneBack = nums[start];
            for (int i = start + 1; i < n; i++)
            {
                robbed = Math.Max(oneBack, twoBack + nums[i]);
                twoBack = oneBack;
                oneBack = robbed;
            }

            return robbed;
        }
    }
}