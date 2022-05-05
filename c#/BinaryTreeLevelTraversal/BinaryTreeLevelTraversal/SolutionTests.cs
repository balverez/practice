using System.Collections.Generic;
using Xunit;

namespace BinaryTreeLevelTraversal
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode testRoot = new(
                data: 1,
                left: new(2),
                right: new(3, new(4), new(5)));

            List<int> expectedList = new() { 1, 2, 3, 4, 5 };

            Assert.Equal(expectedList, new Solution().LevelOrder(testRoot));
        }

        [Fact]
        public void Test2()
        {
            TreeNode testRoot = new(1);

            List<int> expectedList = new() { 1 };

            Assert.Equal(expectedList, new Solution().LevelOrder(testRoot));
        }

        [Fact]
        public void Test3()
        {
            TreeNode testRoot = new(
                data: 1,
                left: new(2),
                right: new(3));

            List<int> expectedList = new() { 1, 2, 3 };

            Assert.Equal(expectedList, new Solution().LevelOrder(testRoot));
        }
    }
}