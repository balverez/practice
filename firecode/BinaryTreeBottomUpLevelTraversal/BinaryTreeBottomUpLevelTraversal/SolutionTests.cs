using System.Collections.Generic;
using Xunit;

namespace BinaryTreeBottomUpLevelTraversal
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 4, 5, 2, 3, 1 };
            TreeNode test = new(1, new(2), new(3, new(4), new(5)));

            Assert.Equal(expected, new Solution().BottomUpLevelOrder(test));
        }
    }
}