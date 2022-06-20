namespace CoinChange
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            int max = amount + 1;
            int[] memo = new int[max];
            Array.Fill(memo, max);
            memo[0] = 0;

            for (int i = 1; i < amount + 1; i++)
                for (int j = 0; j < coins.Length; j++)
                    if (coins[j] <= i)
                        memo[i] = Math.Min(memo[i], memo[i - coins[j]] + 1);

            return memo[amount] > amount ? -1 : memo[amount];
        }
    }
}