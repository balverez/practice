using System.Collections.Generic;
using Xunit;

namespace BinaryTreeAncestors
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 3, 1 }, 5)]
        [InlineData(new int[] { 3, 1 }, 4)]
        [InlineData(new int[] { 1 }, 3)]
        [InlineData(new int[] { 1 }, 2)]
        [InlineData(new int[] { }, 1)]
        public void Test1(int[] expectedArr, int n)
        {
            TreeNode root = new(
                data: 1,
                left: new(2),
                right: new(
                    data: 3,
                    left: new(4),
                    right: new(5)));

            List<int> expected = new(expectedArr);
            Assert.Equal(expected, new Solution().ListAncestors(root, n));
        }
    }
}