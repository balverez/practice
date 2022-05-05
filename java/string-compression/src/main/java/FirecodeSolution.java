public class FirecodeSolution {
    /**
     * Compresses a sorted string by replacing adjacent identical
     * characters with their cardinality if it's >= 2.
     *
     * @param input Sorted string input.
     * @return Compressed string output.
     */
    public String compress(String input) {
      StringBuilder sb = new StringBuilder();
      int accumulator = 0;
      for (int i = 0; i < input.length(); i++) {
        accumulator++;
        if (i + 1 == input.length() || input.charAt(i) != input.charAt(i + 1)) {
          sb.append(input.charAt(i));
          if (accumulator > 1) {
            sb.append(accumulator);
          }
          accumulator = 0;
        }
      }
      return sb.toString();
    }
  }