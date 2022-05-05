public class Solution {
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
        double[] averages = new double[arr.length - k + 1];

        double windowSum = 0;
        int tail = 0;
        int i = 0;
        for (int head = 0; head < arr.length; head++) {
            windowSum += arr[head];
            if (head - tail + 1 == k)
            {
                averages[i++] = windowSum / k;
                windowSum -= arr[tail++];
            }
        }

        return averages;
    }
}
