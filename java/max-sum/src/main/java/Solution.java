public class Solution {
    /**
     * Returns the maximum sum of any contiguous
     * sub-array of size k.
     *
     * @param arr Integer array.
     * @param k   Number of contiguous elements in the sub-array.
     * @return Max sum of a contiguous sub-array of size k.
     */
    public int maxSum(int[] arr, int k)
    {
        int maxSum = 0;
        int tally = 0;
        int usedSlots = 0;

        for (int i = 0; i < arr.length; i++)
        {
            if (usedSlots != k)
            {
                maxSum += arr[i];
                tally = maxSum;
                usedSlots++;
            }
            else
            {
                tally = tally - arr[i - k] + arr[i];
                if (tally > maxSum)
                {
                    maxSum = tally;
                }
            }    
        }

        return maxSum;
    }
}
