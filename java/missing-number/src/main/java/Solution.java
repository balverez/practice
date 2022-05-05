public class Solution {

    /**
     * Returns the missing number in a 1 to 10 sequence
     *
     * @param arr Input array
     * @return Missing integer
     */
    public int missingNumber(int[] arr) {
        int sum = 55;
        for (int i = 0; i < arr.length; i++) {
            sum -= arr[i];
        }
        return sum;
    }
}