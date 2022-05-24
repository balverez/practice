using System;

namespace QuickSort
{
    internal class Algorithm
    {
        internal void QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(array, start, end);
                QuickSort(array, start, pivot - 1);
                QuickSort(array, pivot + 1, end);
            }
        }

        private int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;
            for (int j = start; j < end; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Exchange(array, i, j);
                }
            }

            pivot = i + 1;
            Exchange(array, pivot, end);
            return pivot;
        }

        private void Exchange(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}