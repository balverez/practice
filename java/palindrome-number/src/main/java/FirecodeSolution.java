public class FirecodeSolution {
  /**
   * Returns true if the input integer is a palindrome
   * with constant space complexity.
   *
   * @param input Input integer to be tested.
   * @return True if the input integer is a palindrome.
   */
  public Boolean isPalindrome(int input) {
    int reversed = 0, dividend = input, remainder;
    while (dividend > 0) {
      remainder = dividend % 10;
      reversed = (reversed * 10) + remainder;
      dividend = dividend / 10;
    }
    return reversed == input;
  }
}