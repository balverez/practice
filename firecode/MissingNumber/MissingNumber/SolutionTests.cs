using Xunit;

namespace MissingNumber
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] test = new int[] { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
            int expectedResult = 3;
            Assert.Equal(expectedResult, new Solution().MissingNumber(test));
        }
    }
}