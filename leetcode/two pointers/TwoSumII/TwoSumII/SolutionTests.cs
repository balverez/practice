namespace TwoSumII
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 7, 11, 15 } , 9)]
        [InlineData(new int[] { 1, 3 }, new int[] { 2, 3, 4 } , 6)]
        [InlineData(new int[] { 1, 2 }, new int[] { -1, 0 } , -1)]
        public void Test1(int[] expected, int[] numbers, int target) => Assert.Equal(expected, new Solution().TwoSum(numbers, target));
    }
}