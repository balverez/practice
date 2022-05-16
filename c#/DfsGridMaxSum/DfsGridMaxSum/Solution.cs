using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DfsGridMaxSum
{
    internal class Solution
    {
        internal int MaxSumDfs(int[,] grid)
        {
            return Dfs(grid, 0, 0, 0);
        }

        private int Dfs(int[,] grid, int row, int column, int sum)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);
            if (row >= m || column >= n)
                return 0;

            sum += grid[row, column];
            if (row == m - 1 && column == n - 1)
                return sum;

            return Math.Max(Dfs(grid, row + 1, column, sum), Dfs(grid, row, column + 1, sum));
        }
    }
}
