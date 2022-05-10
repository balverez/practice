public class Solution
{
    /**
     * Rotates the array to the left by k cells.
     *
     * @param arr Input array.
     * @param k   Number of cells to rotate the array to the left by.
     * @return Rotated array.
     */
    public int[] rotateLeft(int[] arr, int k)
    {
        if (arr.length <= 1)
        {
            return arr;
        }

        k = k % arr.length;

        arr = reverse(arr, 0, arr.length - 1);
        arr = reverse(arr, 0, arr.length - 1 - k);
        arr = reverse(arr, arr.length - k, arr.length - 1);

        return arr;
    }

    private int[] reverse(int[] arr, int left, int right)
    {
        while (left < right)
        {
            int temp = arr[left];
            arr[left++] = arr[right];
            arr[right--] = temp;
        }

        return arr;
    }
}