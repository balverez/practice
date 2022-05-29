namespace ContainsDuplicate
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, new int[] { 1, 2, 3, 1 })]
        [InlineData(false, new int[] { 1, 2, 3, 4 })]
        [InlineData(true, new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })]
        public void Test1(bool expected, int[] test) => Assert.Equal(expected, new Solution().ContainsDuplicate(test));
    }
}