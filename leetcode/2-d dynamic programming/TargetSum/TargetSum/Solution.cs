namespace TargetSum
{
    public class Solution
    {
        //O(nm) time, where n is the number of elements and m is the sum of the input.
        //O(m) space, where m is the sum of the input.
        public int FindTargetSumWays(int[] nums, int target)
        {
            int total = nums.Sum();
            if (Math.Abs(target) > total)
                return 0;

            int boundary = (2 * total) + 1;
            int[] dp = new int[boundary];
            dp[nums[0] + total] = 1;
            dp[-nums[0] + total] += 1;

            for (int i = 1; i < nums.Length; i++)
            {
                int[] next = new int[boundary];
                for (int sum = -total; sum <= total; sum++)
                {
                    if (dp[sum + total] > 0)
                    {
                        next[sum + nums[i] + total] += dp[sum + total];
                        next[sum - nums[i] + total] += dp[sum + total];
                    }
                }

                dp = next;
            }

            return dp[target + total];
        }
    }
}