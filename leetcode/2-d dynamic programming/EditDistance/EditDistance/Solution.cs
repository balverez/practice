namespace EditDistance
{
    public class Solution
    {
        public int MinDistance(string word1, string word2)
        {
            if (word1.Length * word2.Length == 0)
                return word1.Length + word2.Length;

            int m = word1.Length + 1;
            int n = word2.Length + 1;

            int[,] dp = new int[m, n];
            for (int i = 0; i < m; i++)
                dp[i, 0] = i;

            for (int j = 0; j < n; j++)
                dp[0, j] = j;

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    int pastRow = i - 1;
                    int pastCol = j - 1;
                    if (word1[pastRow] == word2[pastCol])
                        dp[i, j] = dp[pastRow, pastCol];
                    else
                        dp[i, j] = 1 + Math.Min(dp[i, pastCol], Math.Min(dp[pastRow, j], dp[pastRow, pastCol]));
                }
            }

            return dp[word1.Length, word2.Length];
        }
    }
}