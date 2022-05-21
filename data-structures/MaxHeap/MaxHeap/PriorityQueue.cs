using System;

namespace MaxHeap
{
    //O(n)
    internal class PriorityQueue : MaxHeap
    {
        internal PriorityQueue(int n) : base(n) { }

        //O(1) time
        internal int Max()
        {
            if (HeapSize < 1)
                throw new IndexOutOfRangeException("heap underflow");
            
            return Array[0];
        }


        //O(logn) time
        internal int ExtractMax()
        {
            int max = Max();
            
            Array[0] = Array[HeapSize - 1];
            HeapSize--;
            MaxHeapify(0);
            
            return max;
        }

        //O(logn) time
        internal void IncreaseKey(int i, int k)
        {
            if (i < HeapSize && k < Array[i])
                throw new InvalidOperationException("new key is smaller than current key");

            Array[i] = k;
            while (i > 0 && Array[Parent(i)] < Array[i])
            {
                Exchange(i, Parent(i));
                i = Parent(i);
            }
        }

        //O(logn)
        internal void Insert(int k)
        {
            if (HeapSize == _n)
                throw new InvalidOperationException("priority queue capacity has been exceeded");

            HeapSize++;
            int key = k;
            k = int.MinValue;
            Array[HeapSize - 1] = k;
            IncreaseKey(HeapSize - 1, key);
        }
    }
}