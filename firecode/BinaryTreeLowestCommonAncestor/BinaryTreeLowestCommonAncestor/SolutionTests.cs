using Xunit;

namespace BinaryTreeLowestCommonAncestor
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(2, 4, 5)]
        [InlineData(1, 5, 3)]
        [InlineData(1, 4, 3)]
        [InlineData(2, 4, 2)]
        public void Test1(int expected, int n1, int n2)
        {
            TreeNode test = new(1, new(2, new(4), new(5)), new(3));

            Assert.Equal(expected, new Solution().LCA(test, n1, n2));
        }
    }
}