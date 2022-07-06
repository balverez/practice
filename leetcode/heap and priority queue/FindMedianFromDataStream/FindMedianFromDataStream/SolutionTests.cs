namespace FindMedianFromDataStream
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            MedianFinder mf = new();
            mf.AddNum(1);
            Assert.Equal(1, mf.FindMedian());
            
            mf.AddNum(2);
            Assert.Equal(1.5, mf.FindMedian());
            
            mf.AddNum(3);
            Assert.Equal(2, mf.FindMedian());
        }
    }
}