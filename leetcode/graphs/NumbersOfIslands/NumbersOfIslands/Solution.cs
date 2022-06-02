namespace NumbersOfIslands
{
    public class Solution
    {
        //O(m * n) time
        //O(m * n) space
        public int NumIslands(char[][] grid)
        {
            int islandCount = 0;
            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        islandCount++;
                        DfsSearch(grid, i, j, m, n);
                    }
                }

                
            return islandCount;
        }

        private void DfsSearch(char[][] grid, int i, int j, int m, int n)
        {
            if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] == '0')
                return;

            grid[i][j] = '0';
            DfsSearch(grid, i - 1, j, m, n);
            DfsSearch(grid, i + 1, j, m, n);
            DfsSearch(grid, i, j - 1, m, n);
            DfsSearch(grid, i, j + 1, m, n);
        }
    }
}