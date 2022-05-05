import java.util.Deque;
import java.util.LinkedList;
import java.util.Map;

public class FirecodeSolution {
  /**
   * Checks if the input string of brackets is valid.
   *
   * @param str String containing bracket characters.
   * @return True if the string is valid.
   */
  public Boolean checkValid(String str) {
    Map<Character, Character> openClosePairs =
      Map.of('(', ')', '[', ']', '{', '}');
    Deque<Character> stack = new LinkedList<>();
    for (char c : str.toCharArray()) {
      if (openClosePairs.containsKey(c)) stack.push(openClosePairs.get(c));
      else if (stack.isEmpty() || (!stack.pop().equals(c)))
        return false;
    }
    return stack.isEmpty();
  }
}