using System.Collections.Generic;
using Xunit;

namespace IntervalInsert
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<List<int>> expected = new()
            {
                { new() { 1, 6 } },
                { new() { 7, 9 } }
            };

            List<List<int>> test = new()
            {
                { new() { 1, 4 } },
                { new() { 7, 9 } }
            };

            List<int> testInterval = new() { 2, 6 };

            Assert.Equal(expected, new Solution().InsertInterval(test, testInterval));
        }

        [Fact]
        public void Test2()
        {
            List<List<int>> expected = new()
            {
                { new() { 0, 1 } },
                { new() { 2, 3 } },
                { new() { 4, 5 } }
            };

            List<List<int>> test = new()
            {
                { new() { 0, 1 } },
                { new() { 4, 5 } }
            };

            List<int> testInterval = new() { 2, 3 };

            Assert.Equal(expected, new Solution().InsertInterval(test, testInterval));
        }
    }
}