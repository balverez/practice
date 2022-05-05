using System.Collections.Generic;
using Xunit;

namespace PreOrderTraversal
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode testRoot = new TreeNode(
                1,
                new TreeNode(2, new TreeNode(4), new TreeNode(5)),
                new TreeNode(3, null, new TreeNode(6)));

            List<int> expectedList = new List<int>() { 1, 2, 4, 5, 3, 6 };

            Assert.Equal(expectedList, new Solution().PreOrder(testRoot));
        }
    }
}