using System.Collections.Generic;
using Xunit;

namespace GenerateAdjacencyList
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            Dictionary<string, List<string>> expected = new() {
                { "SFO", new() { "AUS", "MIA" } }
            };

            List<List<string>> test = new()
            {
                { new() { "SFO", "AUS" } },
                { new() { "SFO", "MIA" } }
            };

            var result = new Solution().GraphAdjacencyList(test);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            Dictionary<string, List<string>> expected = new()
            {
                { "SFO", new() { "AUS", "MIA" } },
                { "JFK", new() { "MIA" } }
            };

            List<List<string>> test = new()
            {
                { new() { "SFO", "AUS" } },
                { new() { "SFO", "MIA" } },
                { new() { "JFK", "MIA" } }
            };

            var result = new Solution().GraphAdjacencyList(test);

            Assert.Equal(expected, result);
        }
    }
}