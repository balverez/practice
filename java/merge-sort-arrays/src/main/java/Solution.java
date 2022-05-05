public class Solution {
    /**
     * Merges two sorted arrays.
     *
     * @param arr1 First sorted array.
     * @param arr2 Second sorted array.
     * @return Merged sorted array.
     */
    public int[] mergeSorted(int[] arr1, int[] arr2)
    {
        int n1 = arr1.length;
        int n2 = arr2.length;
        
        int[] result = new int[n1 + n2];
        System.arraycopy(arr1, 0, result, 0, n1);
        System.arraycopy(arr2, 0, result, n1, n2);

        int[] left = new int[n1 + 1];
        int[] right = new int[n2 + 1];

        int i;
        for (i = 0; i < n1; i++)
        {
            left[i] = arr1[i];
        }

        int j;
        for (j = 0; j < n2; j++)
        {
            right[j] = arr2[j];
        }

        left[n1] = Integer.MAX_VALUE;
        right[n2] = Integer.MAX_VALUE;

        i = 0;
        j = 0;
        for (int k = 0; k < result.length; k++)
        {
            if (left[i] <= right[j])
            {
                result[k] = left[i];
                i++;
            }
            else
            {
                result[k] = right[j];
                j++;
            }
        }

        return result;
    }
}