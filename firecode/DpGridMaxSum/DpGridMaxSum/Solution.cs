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

            int[,] result = new int[m, n];
            result[0, 0] = grid[0, 0];

            for (int i = 1; i < m; i++)
                result[i, 0] = grid[i, 0] + result[i - 1, 0];

            for (int j = 1; j < n; j++)
                result[0, j] = grid[0, j] + result[0, j - 1];

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    result[i, j] = grid[i, j] + Math.Max(result[i - 1, j], result[i, j - 1]);

            return result[m - 1, n - 1];
        }
    }
}