namespace Islands
{
    internal class Solution
    {
        //O(m*n) time
        //O(m*n) space
        internal int CountIslands(int[,] grid)
        {
            int islandCount = 0;
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        islandCount++;
                        DfsSearch(grid, i, j, ref m, ref n);
                    }
                }

            return islandCount;
        }

        private void DfsSearch(int[,] grid, int i, int j, ref int m, ref int n)
        {
            if (i < 0 || i >= m || j < 0 || j >= n || grid[i, j] != 1)
                return;

            grid[i, j] = 0;
            DfsSearch(grid, i - 1, j, ref m, ref n);
            DfsSearch(grid, i + 1, j, ref m, ref n);
            DfsSearch(grid, i, j - 1, ref m, ref n);
            DfsSearch(grid, i, j + 1, ref m, ref n);
        }
    }
}