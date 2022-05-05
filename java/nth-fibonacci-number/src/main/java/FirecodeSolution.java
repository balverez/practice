public class FirecodeSolution {
  /**
   * Returns the nth Fibonacci number in linear time and
   * with constant space.
   *
   * @param n Which number to return in the sequence.
   * @return Nth Fibonacci number.
   */
  public long betterFibonacci(int n) {
    if (n == 0) return 0;
    else if (n <= 2) return 1;
    long nMinus1 = 1, nMinus2 = 1, out = nMinus1 + nMinus2;
    for (int i = 3; i <= n; i++) {
      out = nMinus1 + nMinus2;
      nMinus2 = nMinus1;
      nMinus1 = out;
    }
    return out;
  }
}