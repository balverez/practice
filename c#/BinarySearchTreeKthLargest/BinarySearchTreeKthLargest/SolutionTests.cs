using Xunit;

namespace BinarySearchTreeKthLargest
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode rightNode = new(8, new(5), new(10));
            TreeNode test = new(4, new(2), rightNode);
            int k = 4;
            int expected = 4;

            Assert.Equal(expected, new Solution().KthLargest(test, k));
        }
    }
}