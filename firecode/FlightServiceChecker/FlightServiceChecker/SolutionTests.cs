using System.Collections.Generic;
using Xunit;

namespace FlightServiceChecker
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, "SFO", "IAH")]
        [InlineData(true, "TPA", "MIA")]
        [InlineData(false, "AUS", "MIA")]
        public void Test1(bool expected, string origin, string destination)
        {
            Dictionary<string, List<string>> originDestinationsMap = new()
            {
                { "SFO", new() { "AUS", "MIA", "JFK" } },
                { "JFK", new() { "MIA", "TPA" } },
                { "AUS", new() { "IAH" } },
                { "IAH", new() { "AUS" } },
                { "TPA", new() { "JFK" } }
            };

            Assert.Equal(expected, new Solution().FlightCheck(originDestinationsMap, origin, destination));
        }
    }
}