public class FirecodeSolution {

  /**
   * Recursively raises base to exponent and returns
   * the result.
   *
   * @param base     The base.
   * @param exponent The power the base should be raised to.
   * @return Result of base ^ exponent.
   */
  public double betterPow(double base, int exponent) {
    if (exponent == 0) return 1D;
    if (exponent < 0) return betterPow(1 / base, -exponent);
    if (exponent % 2 == 1) return base * betterPow(base, exponent - 1);
    else return betterPow(base * base, exponent / 2);
  }
}