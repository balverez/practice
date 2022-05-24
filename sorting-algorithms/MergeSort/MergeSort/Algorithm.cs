namespace MergeSort
{
    internal class Algorithm
    {
        internal void MergeSort(int[] array)
        {
            if (array.Length > 1)
            {
                int midpoint = array.Length / 2;
                int[] leftArr = new int[midpoint];
                int[] rightArr = new int[array.Length - midpoint];

                for (int i = 0; i < midpoint; i++)
                    leftArr[i] = array[i];

                for (int i = midpoint; i < array.Length; i++)
                    rightArr[i - midpoint] = array[i];

                MergeSort(leftArr);
                MergeSort(rightArr);
                Merge(array, leftArr, rightArr);
            }
        }

        private void Merge(int[] array, int[] leftHalf, int[] rightHalf)
        {
            int nl = leftHalf.Length;
            int nr = rightHalf.Length;

            int i = 0;
            int j = 0;
            int k = 0;
            while (i < nl && j < nr)
            {
                if (leftHalf[i] < rightHalf[j])
                    array[k++] = leftHalf[i++];
                else
                    array[k++] = rightHalf[j++];
            }

            while (i < nl)
                array[k++] = leftHalf[i++];

            while (j < nr)
                array[k++] = rightHalf[j++];
        }
    }
}