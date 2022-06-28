namespace Pow
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(1024D, 2D, 10)]
        [InlineData(9.261D, 2.1D, 3)]
        [InlineData(0.25D, 2D, -2)]
        [InlineData(16, 2, 4)]
        public void Tests(double expected, double x, int n) => Assert.Equal(expected, new Solution().MyPow(x, n), 10);
    }
}