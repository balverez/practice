namespace MaxHeap
{
    //O(n) space
    internal class MaxHeap
    {
        private protected int _n;
        internal int[] Array { get; set; }
        internal int HeapSize { get; set; }

        internal MaxHeap(int n)
        {
            _n = n;
            Array = new int[_n];
            HeapSize = 0;
        }

        internal MaxHeap(int[] array)
        {
            _n = array.Length;
            Array = array;
            HeapSize = array.Length;
        }

        //O(nlogn)
        internal void HeapSort()
        {
            BuildMaxHeap();
            for (int i = HeapSize - 1; i > 0; i--)
            {
                Exchange(0, HeapSize - 1);
                HeapSize--;
                MaxHeapify(0);
            }
        }

        //O(n) time
        internal void BuildMaxHeap()
        {
            for (int i = (HeapSize >> 1) - 1; i >= 0; i--)
                MaxHeapify(i);
        }

        //O(logn) time
        internal void MaxHeapify(int i)
        {
            int left = Left(i);
            int right = Right(i);

            int largest;
            if (left < HeapSize && Array[left] > Array[i])
                largest = left;
            else
                largest = i;

            if (right < HeapSize && Array[right] > Array[largest])
                largest = right;

            if (largest != i)
            {
                Exchange(i, largest);
                MaxHeapify(largest);
            }
        }

        //O(1) time
        private protected int Parent(int i) => i >> 1;

        //O(1) time
        private protected int Left(int i) => (i << 1) + 1;

        //O(1) time
        private protected int Right(int i) => (i << 1) + 2;

        //O(1) time
        private protected void Exchange(int i, int j)
        {
            int temp = Array[i];
            Array[i] = Array[j];
            Array[j] = temp;
        }
    }
}