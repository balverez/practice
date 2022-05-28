namespace MergeSortArrays
{
    internal class Solution
    {
        internal int[] MergeSort(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];

            int i = 0;
            int j = 0;
            int k = 0;
            while (i < arr1.Length && j < arr2.Length)
                result[k++] = arr1[i] < arr2[j] ? arr1[i++] : arr2[j++];

            while (i < arr1.Length)
                result[k++] = arr1[i++];

            while (j < arr2.Length)
                result[k++] = arr2[j++];

            return result;
        }
    }
}