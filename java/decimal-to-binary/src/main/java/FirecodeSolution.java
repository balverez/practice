public class FirecodeSolution {
  /**
   * Returns the minimal binary string representation of
   * the input decimal integer.
   *
   * @param decimal Positive decimal integer that's <= 1000.
   * @return String with binary representation of the input decimal.
   */
  public String toBinary(int decimal) {
    if (decimal <= 1) {
      return String.valueOf(decimal);
    }
    return toBinary(decimal / 2) + decimal % 2;
  }
}