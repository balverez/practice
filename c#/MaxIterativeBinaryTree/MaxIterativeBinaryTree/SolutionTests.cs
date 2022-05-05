using Xunit;

namespace MaxIterativeBinaryTree
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode test = new TreeNode(
                data: 1,
                left: new TreeNode(2),
                right: new TreeNode(3, new TreeNode(4), new TreeNode(5)));

            int expected = 5;

            Assert.Equal(expected, new Solution().Max(test));
        }
    }
}