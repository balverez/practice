namespace SumOfTwoIntegers
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(5, 2, 3)]
        [InlineData(20, 9, 11)]
        public void Tests(int expected, int a, int b) => Assert.Equal(expected, new Solution().GetSum(a, b));
    }
}