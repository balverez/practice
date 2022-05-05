public class FirecodeSolution {
  /**
   * Reverses the input integer with constant space complexity.
   *
   * @param input Input integer to be reversed.
   * @return Reversed integer.
   */
  public int reverse(int input) {
    int reversed = 0;
    while (input > 0) {
      reversed = (reversed * 10) + (input % 10);
      input = input / 10;
    }
    return reversed;
  }
}