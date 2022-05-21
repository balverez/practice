using Xunit;

namespace MaxHeap
{
    public class StructureTests
    {
        [Fact]
        public void Test1()
        {
            int[] expected = { 16, 14, 10, 8, 7, 9, 3, 2, 4, 1 };
            int[] test = { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };

            MaxHeap heap = new(test);
            heap.BuildMaxHeap();
            Assert.Equal(expected, heap.Array);
        }

        [Fact]
        public void Test2()
        {
            int[] expected = { 1, 2, 3, 4, 7, 8, 9, 10, 14, 16 };
            int[] test = { 4, 1, 3, 2, 16, 9, 10, 14, 8, 7 };

            MaxHeap heap = new(test);
            heap.HeapSort();
            Assert.Equal(expected, heap.Array);
        }

        [Fact]
        public void Test3()
        {
            int expected = 3;
            PriorityQueue queue = new(expected);
            queue.Insert(1);
            queue.Insert(2);
            queue.Insert(3);

            Assert.Equal(expected, queue.Max());

            expected = 2;
            queue.ExtractMax();

            Assert.Equal(expected, queue.Max());
        }
    }
}