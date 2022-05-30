namespace KthLargestElementStream
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            KthLargest heap = new(3, new int[] { 4, 5, 8, 2 });
            Assert.Equal(4, heap.Add(3));
            Assert.Equal(5, heap.Add(5));
            Assert.Equal(5, heap.Add(10));
            Assert.Equal(8, heap.Add(9));
            Assert.Equal(8, heap.Add(4));
        }
    }
}