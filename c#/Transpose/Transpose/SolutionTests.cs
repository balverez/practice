using Xunit;

namespace Transpose
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[,] test = new int[2,2] { { 255, 0 }, { 255, 255 } };
            int[,] expectedResult = new int[2,2] { { 255, 255 }, { 0, 255 } };
            Assert.Equal(expectedResult, new Solution().Transpose(test));
        }
    }
}