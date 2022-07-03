namespace DetectSquares
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            DetectSquares detectSquares = new();
            detectSquares.Add(new int[] { 3, 10 });
            detectSquares.Add(new int[] { 11, 2 });
            detectSquares.Add(new int[] { 3, 2 });
            Assert.Equal(1, detectSquares.Count(new int[] { 11, 10 }));
            Assert.Equal(0, detectSquares.Count(new int[] { 14, 8 }));
            detectSquares.Add(new int[] { 11, 2 });
            Assert.Equal(2, detectSquares.Count(new int[] { 11, 10 }));
        }
    }
}