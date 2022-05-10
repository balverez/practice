public class FirecodeSolution {
  /**
   * Rotates the array to the left by k cells.
   *
   * @param arr Input array.
   * @param k   Number of cells to rotate the array to the left by.
   * @return Rotated array.
   */
  public int[] rotateLeft(int[] arr, int k) {
    if (arr.length <= 1) return arr;
    int stepShifts = k % arr.length;
    reverse(arr, 0, arr.length - 1);
    reverse(arr, 0, arr.length - 1 - stepShifts);
    reverse(arr, arr.length - stepShifts, arr.length - 1);
    return arr;
  }

  private void reverse(int[] arr, int leftIndex, int rightIndex) {
    while (leftIndex < rightIndex) {
      int temp = arr[leftIndex];
      arr[leftIndex++] = arr[rightIndex];
      arr[rightIndex--] = temp;
    }
  }
}