using Xunit;

namespace DuplicateNumbers
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 4, 3, 1, 4, 2, 1, 4 }, new int[] { 1, 4 })]
        [InlineData(new int[] { 1, 5, 23, 2, 6, 3, 1, 8, 12, 3 }, new int[] { 1, 3 })]
        public void Test1(int[] testArr, int[] expectedArr)
        {
            Assert.Equal(new Solution().FindDuplicateNumbers(testArr), expectedArr);
        }
    }
}