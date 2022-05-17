import java.util.HashSet;
import java.util.LinkedList;
import java.util.Set;
import java.util.stream.Collectors;

public class Solution {
  /**
   * Returns all paths from the top left cell to
   * the bottom right cell.
   *
   * @param board Input 2D array.
   * @return Set of all paths as strings.
   */
  public Set<String> returnPaths(char[][] board) {
    Set<String> result = new HashSet<>();
    pathDfs(board, result, "", 0, 0);
    return result;
  }
  
  private void pathDfs(char[][] board, Set<String> paths, String str, int row, int column) {
    int m = board.length;
    int n = board[0].length;
    
    if (row >= m || column >= n) {
      return;
    }
    
    str = str + board[row][column];
    if (row == m - 1 && column == n - 1) {
      paths.add(str);
      return;
    }
    
    pathDfs(board, paths, str, row + 1, column);
    pathDfs(board, paths, str, row, column + 1);
  }
}