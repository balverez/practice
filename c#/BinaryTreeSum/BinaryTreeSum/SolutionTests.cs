using Xunit;

namespace BinaryTreeSum
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode testRoot = new TreeNode(
                data: 1,
                left: new TreeNode(2),
                right: new TreeNode(3, new TreeNode(4), new TreeNode(5)));

            int test = 2;
            bool expected = true;

            Assert.Equal(expected, new Solution().SumNodes(testRoot));
        }
    }
}