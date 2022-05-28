using System.Collections.Generic;
using Xunit;

namespace BinaryTreeIterativeInOrderTraversal
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode rightNode = new(3, new(4), new(5));
            TreeNode test = new(1, new(2), rightNode);

            List<int> expected = new() { 2, 1, 4, 3, 5 };

            Assert.Equal(expected, new Solution().InOrder(test));
        }
    }
}