using Xunit;

namespace BinaryTreeNodeDistance
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 6)]
        public void Test(int expected, int test)
        {
            TreeNode root = new(
                data: 1,
                left: new(
                    data: 2,
                    left: new(4),
                    right: new(5)),
                right: new(
                    data: 3,
                    left: null,
                    right: new(6)));

            Assert.Equal(expected, new Solution().NodeDistance(root, test));
        }
    }
}