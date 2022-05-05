using System.Collections.Generic;
using Xunit;

namespace PreorderIterativeTraversal
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
            List<int> expected = new List<int>() { 1, 2, 3, 4, 5 };

            Assert.Equal(expected, new Solution().PreOrder(testRoot));
        }
    }
}