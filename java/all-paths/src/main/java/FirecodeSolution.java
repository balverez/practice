import java.util.HashSet;
import java.util.LinkedList;
import java.util.Set;
import java.util.stream.Collectors;

public class FirecodeSolution {
  /**
   * Returns all paths from the top left cell to
   * the bottom right cell.
   *
   * @param board Input 2D array.
   * @return Set of all paths as strings.
   */
  public Set<String> returnPaths(char[][] board) {
    Set<String> paths = new HashSet<>();
    LinkedList<Character> charsSoFar = new LinkedList<>();
    dfs(board, paths, 0, 0, charsSoFar);
    return paths;
  }

  /**
   * Performs the depth first search and populates the input set.
   *
   * @param board      Input 2D array.
   * @param paths      Set of all paths as strings.
   * @param r          Current row index.
   * @param c          Current column index.
   * @param charsSoFar List of characters encountered so far on traversal.
   */
  private void dfs(
    char[][] board,
    Set<String> paths,
    int r,
    int c,
    LinkedList<Character> charsSoFar
  ) {
    if (r == board.length || c == board[0].length) return;
    charsSoFar.add(board[r][c]);
    if (r == board.length - 1 && c == board[0].length - 1) {
      paths.add(charsSoFar.stream().map(String::valueOf).collect(Collectors.joining()));
    }
    dfs(board, paths, r + 1, c, charsSoFar);
    dfs(board, paths, r, c + 1, charsSoFar);
    charsSoFar.removeLast();
  }
}