import java.util.ArrayList;
import java.util.List;

public class FirecodeSolution {
  /**
   * Returns the integers in the matrix in clockwise
   * spiral order.
   *
   * @param matrix Input matrix.
   * @return List of integers in clockwise spiral order.
   */
  public List<Integer> dumpSpiral(int[][] matrix) {
    List<Integer> out = new ArrayList<>();
    int rows = matrix.length, cols = matrix[0].length;
    boolean[][] seen = new boolean[rows][cols];
    int[] rowIncrements = {0, 1, 0, -1};
    int[] colIncrements = {1, 0, -1, 0};
    int r = 0, c = 0, direction = 0;
    for (int i = 0; i < rows * cols; i++) {
      out.add(matrix[r][c]);
      seen[r][c] = true;
      int maybeNextR = r + rowIncrements[direction];
      int maybeNextC = c + colIncrements[direction];
      if (maybeNextR >= 0 && maybeNextR < rows && maybeNextC >= 0 &&
            maybeNextC < cols && !seen[maybeNextR][maybeNextC]) {
        r = maybeNextR;
        c = maybeNextC;
      } else {
        direction = (direction + 1) % 4;
        r += rowIncrements[direction];
        c += colIncrements[direction];
      }
    }
    return out;
  }
}