using System.Collections.Generic;
using Xunit;

namespace SpiralMatrix
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            int[,] test = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Assert.Equal(expected, new Solution().DumpSpiral(test));
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new() { 1, 2, 4, 3};
            int[,] test = new int[,] { { 1, 2 }, { 3, 4 } };
            Assert.Equal(expected, new Solution().DumpSpiral(test));
        }
    }
}