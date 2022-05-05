public class FirecodeSolution {
    /**
     * Returns the average of all contiguous sub-arrays
     * of size k in the given integer array, starting with
     * the first element.
     *
     * @param arr Integer array.
     * @param k   Number of contiguous elements in the sub-array.
     * @return Array of averages.
     */
    public double[] averages(int[] arr, int k) {
      double[] out = new double[arr.length - k + 1];
      double windowSum = 0D;
      int left = 0;
      for (int right = 0; right < arr.length; right++) {
        windowSum += arr[right];
        if (right - left + 1 == k) {
          out[left] = windowSum / k;
          windowSum -= arr[left++];
        }
      }
      return out;
    }
  }