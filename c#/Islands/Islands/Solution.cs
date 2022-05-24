namespace Islands
{
    internal class Solution
    {
        //O(m * n) time
        //O(m * n) space
        public int CountIslands(int[,] grid)
        {
            int count = 0;
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

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

        private void Dfs(int[,] grid, int i, int j, int m, int n)
        {
            if (i < 0 || i >= m || j < 0 || j >= n || grid[i, j] != 1)
                return;

            grid[i, j] = 0;
            Dfs(grid, i - 1, j, m, n);
            Dfs(grid, i + 1, j, m, n);
            Dfs(grid, i, j - 1, m, n);
            Dfs(grid, i, j + 1, m, n);
        }
    }
}