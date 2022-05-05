using Xunit;

namespace BinarySearchTreeMax
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode testRoot = new TreeNode(
                data: 10,
                left: new(5, new(4), new(6)),
                right: new(15, new(14), new(16)));

            int expected = 16;

            Assert.Equal(expected, new Solution().MaxData(testRoot));
        }
    }
}