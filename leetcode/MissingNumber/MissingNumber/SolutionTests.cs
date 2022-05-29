namespace MissingNumber
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(2, new int[] { 3, 0, 1 })]
        [InlineData(2, new int[] { 0, 1 })]
        [InlineData(8, new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 })]
        public void Test(int expected, int[] test) => Assert.Equal(expected, new Solution().MissingNumber(test));
    }
}