namespace PartitionEqualSubsetSum
{
    public class Solution
    {
        //O(mn) time, where m is the target sum and n is the length of the nums array.
        //O(mn) space
        public bool CanPartition(int[] nums)
        {
            int sum = nums.Sum();
            if (nums.Length == 1 || (sum % 2) == 1)
                return false;

            int target = sum / 2;
            int[,] memo = new int[target + 1, nums.Length];
            for (int i = 0; i < target + 1; i++)
                for (int j = 0; j < nums.Length; j++)
                    memo[i, j] = -1;

            return DFS(memo, nums, target, 0, 0);
        }

        private bool DFS(int[,] memo, int[] nums, int target, int sum, int i)
        {
            if (sum == target)
                return true;
            if (i >= nums.Length || sum > target)
                return false;
            if (memo[sum, i] >= 0)
                return memo[sum, i] == 1;

            bool result = DFS(memo, nums, target, sum + nums[i], i + 1)
                || DFS(memo, nums, target, sum, i + 1);
            memo[sum, i] = result ? 1 : 0;

            return result;
        }
    }
}