public class FirecodeSolution {
  /**
   * Returns the maximum sum of any contiguous
   * sub-array of size k.
   *
   * @param arr Integer array.
   * @param k   Number of contiguous elements in the sub-array.
   * @return Max sum of a contiguous sub-array of size k.
   */
  public int maxSum(int[] arr, int k) {
    int windowSum = 0, maxSum = 0;
    int left = 0;
    for (int right = 0; right < arr.length; right++) {
      windowSum += arr[right];
      if (right - left + 1 == k) {
        maxSum = Math.max(maxSum, windowSum);
        windowSum -= arr[left++];
      }
    }
    return maxSum;
  }
}