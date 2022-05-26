using System.Linq;
using Xunit;

namespace GoogleOTS
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 4, 9 }, "ABABAABBBB", 2, 3)]
        [InlineData(new int[] { 4 }, "ABABAABB", 2, 2)]
        [InlineData(new int[] { 1, 3 }, "AABB", 1, 1)]
        public void Test1(int[] expected, string test, int x, int y)
        {
            Assert.Equal(expected.ToList(), new Solution().CutString(test, x, y));
        }
    }
}