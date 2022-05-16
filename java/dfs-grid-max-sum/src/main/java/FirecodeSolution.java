public class FirecodeSolution {
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


  /**
   * Dfs helper method
   */
  private int dfs(int[][] grid, int r, int c, int sum) {
    if (r >= grid.length || c >= grid[0].length) return -1;
    else if (r == grid.length - 1 && c == grid[0].length - 1)
      return sum + grid[r][c];
    else return Math.max(
        dfs(grid, r + 1, c, sum + grid[r][c]),
        dfs(grid, r, c + 1, sum + grid[r][c]));
  }
}