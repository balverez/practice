﻿namespace KthLargestElementStream
{
    public class KthLargest
    {
        private int _k;
        private PriorityQueue<int, int> _maxHeap;

        //O(nlogn) time
        //O(n) space
        public KthLargest(int k, int[] nums)
        {
            _k = k;
            _maxHeap = new();

            foreach (int i in nums)
                _maxHeap.Enqueue(i, i);

            while (_maxHeap.Count > _k)
                _maxHeap.Dequeue();
        }

        //O(k) time
        //O(1) space
        public int Add(int val)
        {
            _maxHeap.Enqueue(val, val);

            while (_maxHeap.Count > _k)
                _maxHeap.Dequeue();

            return _maxHeap.Peek();
        }
    }
}