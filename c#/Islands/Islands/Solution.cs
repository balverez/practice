namespace Islands
{
    internal class Solution
    {
        public int CountIslands(int[,] grid)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);
            int count = 0;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        count++;
                        Dfs(grid, i, j, m, n);
                    }
                }

            return count;
        }

        private void Dfs(int[,] grid, int row, int column, int m, int n)
        {
            if (row < 0 || row >= m || column < 0 || column >= n || grid[row, column] != 1)
                return;

            grid[row, column] = 0;
            Dfs(grid, row - 1, column, m, n);
            Dfs(grid, row + 1, column, m, n);
            Dfs(grid, row, column - 1, m, n);
            Dfs(grid, row, column + 1, m, n);
        }
    }
}