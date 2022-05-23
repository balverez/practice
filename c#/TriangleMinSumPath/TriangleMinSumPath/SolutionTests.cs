using System.Collections.Generic;
using Xunit;

namespace TriangleMinSumPath
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 3;
            List<List<int>> triangle = new()
            {
                { new() { 1 } },
                { new() { 1, 0 } },
                { new() { 1, 2, 3 } },
                { new() { 7, 2, 0, 1 } }
            };

            Assert.Equal(expected, new Solution().TriangleMinPathSum(triangle));
        }

        [Fact]
        public void Test2()
        {
            int expected = 1;
            List<List<int>> triangle = new()
            {
                { new() { 1 } }
            };

            Assert.Equal(expected, new Solution().TriangleMinPathSum(triangle));
        }

        [Fact]
        public void Test3()
        {
            int expected = 3;
            List<List<int>> triangle = new()
            {
                { new() { 1 } },
                { new() { 2, 3 } }
            };

            Assert.Equal(expected, new Solution().TriangleMinPathSum(triangle));
        }

        [Fact]
        public void Test4()
        {
            int expected = 7;
            List<List<int>> triangle = new()
            {
                { new() { 1 } },
                { new() { 2, 3 } },
                { new() { 4, 5, 6 } }
            };

            Assert.Equal(expected, new Solution().TriangleMinPathSum(triangle));
        }

        [Fact]
        public void Test5()
        {
            int expected = 5;
            List<List<int>> triangle = new()
            {
                { new() { 1 } },
                { new() { 1, 0 } },
                { new() { 1, 2, 3 } },
                { new() { 7, 2, 3, 1 } }
            };

            Assert.Equal(expected, new Solution().TriangleMinPathSum(triangle));
        }

        [Fact]
        public void Test6()
        {
            int expected = 14;
            List<List<int>> triangle = new()
            {
                { new() { 1 } },
                { new() { 2, 3 } },
                { new() { 4, 5, 6 } },
                { new() { 7, 8, 9, 10 } }
            };

            Assert.Equal(expected, new Solution().TriangleMinPathSum(triangle));
        }
    }
}