public class FirecodeSolution {
  /**
   * Merges two sorted arrays.
   *
   * @param arr1 First sorted array.
   * @param arr2 Second sorted array.
   * @return Merged sorted array.
   */
  public int[] mergeSorted(int[] arr1, int[] arr2) {
    int[] sorted = new int[arr1.length + arr2.length];
    int i1 = 0, i2 = 0, iSorted = 0;
    while (i1 < arr1.length && i2 < arr2.length) {
      sorted[iSorted++] = arr1[i1] < arr2[i2] ? arr1[i1++] : arr2[i2++];
    }
    while (i1 < arr1.length) {
      sorted[iSorted++] = arr1[i1++];
    }
    while (i2 < arr2.length) {
      sorted[iSorted++] = arr2[i2++];
    }
    return sorted;
  }
}