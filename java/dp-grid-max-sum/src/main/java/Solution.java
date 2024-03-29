public class Solution {
  /**
   * Returns the sum of the max sum path
   * from the top left to the bottom right cell,
   * with only downward and rightward (by one)
   * movement allowed.
   *
   * @param grid Input grid.
   * @return Sum along the max sum path.
   */
  public int maxSumDp(int[][] grid) {
    int m = grid.length;
    int n = grid[0].length;
    
    int[][] memo = new int[m][n];
    
    memo[0][0] = grid[0][0];
    for (int i = 1; i < m; i++)
    {
      memo[i][0] = memo[i - 1][0] + grid[i][0];
    }
    
    for (int j = 1; j < n; j++)
    {
      memo[0][j] = memo[0][j - 1] + grid[0][j];
    }
    
    for (int i = 1; i < m; i++)
    {
      for (int j = 1; j < n; j++)
      {
        memo[i][j] = Math.max(memo[i - 1][j] + grid[i][j], memo[i][j - 1] + grid[i][j]);
      }
    }
    
    return memo[m - 1][n - 1];
  }
}