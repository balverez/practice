namespace MaximumSubarray
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int MaxSubArray(int[] nums)
        {
            int maximumSubarray = nums[0];
            int currentSubarray = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                currentSubarray = Math.Max(nums[i], currentSubarray + nums[i]);
                maximumSubarray = Math.Max(maximumSubarray, currentSubarray);
            }

            return maximumSubarray;
        }
    }
}