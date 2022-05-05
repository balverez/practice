public class FirecodeSolution {

  /**
   * Recursively raises base to exponent and returns
   * the result.
   *
   * @param base     The base.
   * @param exponent The power the base should be raised to.
   * @return Result of base ^ exponent.
   */
  public long simplePow(int base, int exponent) {
    if (exponent == 0) {
      return 1L;
    }
    return (long) base * simplePow(base, exponent - 1);
  }
}