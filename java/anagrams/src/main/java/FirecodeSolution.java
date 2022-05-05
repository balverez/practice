import java.util.HashMap;
import java.util.Map;

public class FirecodeSolution {
  /**
   * Tests if two input strings are case insensitive anagrams.
   *
   * @param s1 First input string.
   * @param s2 Second input string.
   * @return True if the strings are anagrams, false otherwise.
   */
  public Boolean isPairAnagram(String s1, String s2) {
    Map<Character, Integer> countsMap = new HashMap<>();
    s1.toUpperCase().chars().forEach(c -> countsMap.put(
        (char) c,
        countsMap.getOrDefault((char) c, 0) + 1));
    s2.toUpperCase().chars().forEach(c -> countsMap.put(
        (char) c,
        countsMap.getOrDefault((char) c, 0) - 1));

    return countsMap
        .values()
        .stream()
        .filter(n -> n != 0)
        .findAny()
        .isEmpty();
  }
}
