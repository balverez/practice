import java.util.HashSet;
import java.util.Set;

public class FirecodeSolution {
  /**
   * Given n, generates and returns valid pairs
   * of parentheses.
   *
   * @param n Number of pairs of parentheses to generate.
   * @return Set containing valid combination strings.
   */
  public Set<String> generateParentheses(int n) {
    Set<String> set = new HashSet<>();
    build(set, "", n, n);
    return set;
  }

  private void build(
    Set<String> set,
    String s,
    int openRemaining,
    int closeRemaining
  ) {
    if (openRemaining == 0 && closeRemaining == 0) set.add(s);
    if (openRemaining > 0) {
      build(set, s + "(", openRemaining - 1, closeRemaining);
    }
    if (closeRemaining > openRemaining) {
      build(set, s + ")", openRemaining, closeRemaining - 1);
    }
  }
}