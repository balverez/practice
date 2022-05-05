using Xunit;

namespace RotateImageClockwise
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[,] test = new int[,] { { 1, 0 }, { 0, 0 } };
            int[,] expected = new int[,] { { 0, 1 }, { 0, 0 } };
            Assert.Equal(expected, new Solution().RotateClockwise(test));
        }
    }
}