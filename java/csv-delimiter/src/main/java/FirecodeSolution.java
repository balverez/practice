import java.util.stream.Collectors;

public class FirecodeSolution {
  /**
   * Replaces all commas in a csv string with a provided replacement string.
   *
   * @param csv         Comma separated string
   * @param replacement Replacement string
   * @return String with replacement made
   */
  public String replaceCsvDelimiter(String csv, String replacement) {
    return csv.chars()
        .mapToObj(i -> (char) i)
        .map(s -> s == ',' ? replacement : s.toString())
        .collect(Collectors.joining());
  }
}