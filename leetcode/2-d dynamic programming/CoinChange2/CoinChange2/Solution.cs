namespace CoinChange2
{
    public class Solution
    {
        //O(nm) time, where n is the amount and m is the number of denominations.
        //O(n) space, where n is the amount.
        public int Change(int amount, int[] coins)
        {
            int n = amount + 1;
            int[] memo = new int[n];
            memo[0] = 1;

            foreach (int coin in coins)
                for (int i = coin; i < n; i++)
                    memo[i] += memo[i - coin];

            return memo[amount];
        }
    }
}