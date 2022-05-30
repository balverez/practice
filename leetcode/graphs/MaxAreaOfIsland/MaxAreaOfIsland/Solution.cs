namespace MaxAreaOfIsland
{
    public class Solution
    {
        //O(m * n) time
        //O(m * n) space
        public int MaxAreaOfIsland(int[][] grid)
        {
            int maxArea = 0;
            int m = grid.Length;
            int n = grid[0].Length;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (grid[i][j] == 1)
                    {
                        maxArea = Math.Max(maxArea, IterativeDfs(grid, i, j, m, n));
                    }

            return maxArea;
        }

        //O(m * n) time
        //O(m * n) space
        private int RecursiveDfs(int[][] grid, int i, int j, int m, int n)
        {
            if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] != 1)
                return 0;

            grid[i][j] = 0;
            return 1
                + RecursiveDfs(grid, i - 1, j, m, n)
                + RecursiveDfs(grid, i + 1, j, m, n)
                + RecursiveDfs(grid, i, j - 1, m, n)
                + RecursiveDfs(grid, i, j + 1, m, n);
        }

        //O(m * n) time
        //O(m * n) space
        private int IterativeDfs(int[][] grid, int i, int j, int m, int n)
        {
            int[] rowDirection = { -1, 1, 0, 0 };
            int[] columnDirection = { 0, 0, -1, 1 };

            int area = 0;
            Stack<int[]> stack = new();
            stack.Push(new int[] { i, j });
            grid[i][j] = 0;

            int[] node;
            while (stack.Count > 0)
            {
                node = stack.Pop();
                i = node[0];
                j = node[1];
                area++;

                for (int d = 0; d < 4; d++)
                {
                    int row = i + rowDirection[d];
                    int column = j + columnDirection[d];

                    if (row >= 0 && row < m && column >= 0 && column < n && grid[row][column] == 1)
                    {
                        grid[row][column] = 0;
                        stack.Push(new int[] { row, column });
                    }
                }
            }

            return area;
        }
    }
}