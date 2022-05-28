using Xunit;

namespace BinaryTreeFullNodes
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            TreeNode test = new TreeNode(
                data: 1,
                left: new TreeNode(2),
                right: new TreeNode(3, new TreeNode(4), new TreeNode(5)));

            int expected = 2;

            Assert.Equal(expected, new Solution().CountFull(test));
        }
    }
}