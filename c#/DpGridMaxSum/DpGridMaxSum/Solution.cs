using System;

namespace DpGridMaxSum
{
    //O(n * m) time
    //O(n * m) space
    internal class Solution
    {
        internal int MaxSumDp(int[,] grid)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            int[,] memo = new int[m, n];

            memo[0, 0] = grid[0, 0];
            for (int i = 1; i < m; i++)
                memo[i, 0] = memo[i - 1, 0] + grid[i, 0];

            for (int j = 1; j < n; j++)
                memo[0, j] = memo[0, j - 1] + grid[0, j];

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    memo[i, j] = Math.Max(grid[i, j] + memo[i - 1, j], grid[i, j] + memo[i, j - 1]);

            return memo[m - 1, n - 1];
        }
    }
}