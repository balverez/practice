namespace ClimbingStairs
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        public void Test1(int expected, int n) => Assert.Equal(expected, new Solution().ClimbStairs(n));
    }
}