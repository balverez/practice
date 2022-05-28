using Xunit;

namespace BinaryTreeMinimumDepth
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode testRoot = new(
                data: 1,
                left: new(1),
                right: new(
                    data: 3,
                    left: new(4),
                    right: new(5))
                );

            int expected = 2;

            Assert.Equal(expected, new Solution().MinimumDepth(testRoot));
        }
    }
}