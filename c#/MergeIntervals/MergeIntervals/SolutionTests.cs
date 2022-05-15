using System.Collections.Generic;
using Xunit;

namespace MergeIntervals
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<List<int>> expected = new() { new() { 1, 5 } };
            List<List<int>> test = new() { new() { 1, 3 }, new() { 2, 5 } };
            Assert.Equal(expected, new Solution().MergeIntervals(test));
        }

        [Fact]
        public void Test2()
        {
            List<List<int>> expected = new() { new() { 1, 2 }, new() { 3, 5 } };
            List<List<int>> test = new() { new() { 3, 5 }, new() { 1, 2 } };
            Assert.Equal(expected, new Solution().MergeIntervals(test));
        }

        [Fact]
        public void Test3()
        {
            List<List<int>> expected = new() { new() { 1, 6 }, new() { 8, 10 }, new() { 15, 18 } };
            List<List<int>> test = new() { new() { 1, 3 }, new() { 2, 6 }, new() { 8, 10 }, new() { 15, 18 } };
            Assert.Equal(expected, new Solution().MergeIntervals(test));
        }
    }
}