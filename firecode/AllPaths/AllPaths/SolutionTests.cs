using System.Collections.Generic;
using Xunit;

namespace AllPaths
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            char[,] board = new char[,] { { 'A', 'B' }, { 'C', 'D' } };
            HashSet<string> expected = new() { "ACD", "ABD" };
            Assert.Equal(expected, new Solution().ReturnPaths(board));
        }
    }
}