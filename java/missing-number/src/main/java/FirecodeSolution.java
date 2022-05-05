import java.util.*;

public class FirecodeSolution {
  /**
   * Returns the missing number in a 1 to 10 sequence
   *
   * @param arr Input array
   * @return Missing integer
   */
  public int missingNumber(int[] arr) {
    int expectedSum = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10;
    int actualSum = Arrays.stream(arr).sum();
    return expectedSum - actualSum;
  }
}
