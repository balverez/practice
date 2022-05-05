public class FirecodeSolution {
  /**
   * Takes in a positive integer and returns
   * true if it is a power of two, else false.
   *
   * @param num Integer to test.
   * @return True if the number is a power of two, false otherwise.
   */
  public boolean isPowerOfTwo(int num) {
    return (num & (num - 1)) == 0;
  }
}