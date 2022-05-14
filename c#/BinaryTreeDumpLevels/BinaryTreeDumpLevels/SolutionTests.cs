using System.Collections.Generic;
using Xunit;

namespace BinaryTreeDumpLevels
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TreeNode rightNode = new(3, new(4), new(5));
            TreeNode test = new(1, new(2), rightNode);

            List<List<int>> expected = new List<List<int>>() { new() { 1 }, new() { 2, 3 }, new() { 4, 5 } };

            Assert.True(expected.Equals(new Solution().DumpTree(test)));
        }
    }
}