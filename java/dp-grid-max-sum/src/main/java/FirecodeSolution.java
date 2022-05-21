import java.util.stream.IntStream;

public class FirecodeSolution {
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
    int rows = grid.length, cols = grid[0].length;
    int[][] memo = new int[rows][cols];
    memo[0][0] = grid[0][0];
    IntStream.range(1, rows)
      .forEach(r -> memo[r][0] = memo[r - 1][0] + grid[r][0]);
    IntStream.range(1, cols)
      .forEach(c -> memo[0][c] = memo[0][c - 1] + grid[0][c]);
    for (int r = 1; r < rows; r++) {
      for (int c = 1; c < cols; c++) {
        memo[r][c] = grid[r][c] + Math.max(memo[r - 1][c], memo[r][c - 1]);
      }
    }
    return memo[rows - 1][cols - 1];
  }
}