using System.Collections.Generic;
using Xunit;

namespace BinaryTreeIterativePreOrderTraversal
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

            List<int> expected = new List<int>() { 1, 2, 3, 4, 5 };

            Assert.Equal(expected, new Solution().PreOrder(testRoot));
        }

        [Fact]
        public void Test2()
        {
            TreeNode testRoot = new TreeNode(
                data: 1,
                left: new(2, new(4), new(5)),
                right: new(3, new(6), new(7)));

            List<int> expected = new List<int>() { 1, 2, 4, 5, 3, 6, 7 };

            Assert.Equal(expected, new Solution().PreOrder(testRoot));
        }
    }
}