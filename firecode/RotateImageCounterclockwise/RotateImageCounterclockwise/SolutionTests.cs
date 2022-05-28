using Xunit;

namespace RotateImageCounterclockwise
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            int[,] test = new int[,] { { 1, 0 }, { 0, 0 } };
            int[,] expected = new int[,] { { 0, 0 }, { 1, 0 } };
            Assert.Equal(expected, new Solution().RotateCounterclockwise(test));
        }
    }
}