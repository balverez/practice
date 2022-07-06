namespace BurstBalloons
{
    public class Solution
    {
        //O(n^3) time
        //O(n^2) space
        public int MaxCoins(int[] nums)
        {
            int n = nums.Length + 2;
            int[] balloons = new int[n];
            balloons[0] = 1;
            balloons[n - 1] = 1;
            for (int i = 0; i < nums.Length; i++)
                balloons[i + 1] = nums[i];

            int[,] cache = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    cache[i, j] = int.MinValue;

            return DFS(cache, balloons, 1, n - 2);
        }

        private int DFS(int[,] cache, int[] nums, int left, int right)
        {
            if (left > right)
                return 0;

            if (cache[left, right] >= 0)
                return cache[left, right];

            for (int i = left; i <= right; i++)
            {
                int coins = nums[left - 1] * nums[i] * nums[right + 1];
                coins += DFS(cache, nums, left, i - 1) + DFS(cache, nums, i + 1, right);
                cache[left, right] = Math.Max(cache[left, right], coins);
            }

            return cache[left, right];
        }
    }
}