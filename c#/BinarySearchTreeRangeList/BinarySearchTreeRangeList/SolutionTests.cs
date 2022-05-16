using System.Collections.Generic;
using Xunit;

namespace BinarySearchTreeRangeList
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 2 }, 1, 3)]
        [InlineData(new int[] { 2, 4 }, 1, 4)]
        [InlineData(new int[] { 2, 4 }, 2, 4)]
        public void Test1(int[] expectedArr, int a, int b)
        {
            TreeNode root = new(
                data: 4,
                left: new(2),
                right: new(
                    data: 8,
                    left: new(5),
                    right: new(10)));

            List<int> expected = new(expectedArr);

            Assert.Equal(expected, new Solution().ListInRange(root, a, b));
        }
    }
}