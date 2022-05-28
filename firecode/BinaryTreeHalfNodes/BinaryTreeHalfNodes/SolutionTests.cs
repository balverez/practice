using Xunit;

namespace BinaryTreeHalfNodes
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            TreeNode testRoot = new(
                data: 1,
                left: new(2),
                right: new(3, null, new(5)));

            int expected = 1;

            Assert.Equal(expected, new Solution().CountHalfNodes(testRoot));
        }
    }
}