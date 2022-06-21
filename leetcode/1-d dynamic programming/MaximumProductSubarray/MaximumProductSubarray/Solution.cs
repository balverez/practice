namespace MaximumProductSubarray
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int MaxProduct(int[] nums)
        {
            int max = int.MinValue;
            int curMax = 1;
            int curMin = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                int tmpMax = curMax;
                curMax = Math.Max(nums[i], Math.Max(nums[i] * curMax, nums[i] * curMin));
                curMin = Math.Min(nums[i], Math.Min(nums[i] * tmpMax, nums[i] * curMin));
                max = Math.Max(max, curMax);
            }

            return max;
        }
    }
}