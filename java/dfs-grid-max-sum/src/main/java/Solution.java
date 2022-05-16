public class Solution {
    /**
     * Returns the sum of the max sum path
     * from the top left to the bottom right cell,
     * with only downward and rightward (by one) movement allowed.
     *
     * @param grid Input grid.
     * @return Sum along the max sum path.
     */
    public int maxSumDfs(int[][] grid) {
      return dfs(grid, 0, 0, 0);
    }
    
    private int dfs(int[][] grid, int row, int column, int sum)
    {
      int m = grid.length;
      int n = grid[0].length;
      
      if (row >= m || column >= n)
      {
        return 0;
      }
      
      sum = sum + grid[row][column];
      if (row == m - 1 && column == n - 1)
      {
        return sum;
      }
      
      return Math.max(dfs(grid, row + 1, column, sum), dfs(grid, row, column + 1, sum));
    }
  }