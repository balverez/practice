using Xunit;

namespace BinaryTreeDistanceNodes
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(2, 4, 5)]
        [InlineData(3, 5, 3)]
        [InlineData(3, 4, 3)]
        [InlineData(1, 4, 2)]
        public void Test(int expected, int n1, int n2)
        {
            TreeNode test = new(1, new(2, new(4), new(5)), new(3));

            Assert.Equal(expected, new Solution().Distance(test, n1, n2));
        }
    }
}