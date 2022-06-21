namespace ReconstructItinerary
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<string> expected = new()
            {
                "JFK",
                "MUC",
                "LHR",
                "SFO",
                "SJC"
            };

            IList<IList<string>> tickets = new List<IList<string>>()
            {
                new List<string>() { "MUC", "LHR" },
                new List<string>() { "JFK", "MUC" },
                new List<string>() { "SFO", "SJC" },
                new List<string>() { "LHR", "SFO" }
            };

            Assert.Equal(expected, new Solution().FindItinerary(tickets));
        }

        [Fact]
        public void Test2()
        {
            List<string> expected = new()
            {
                "JFK",
                "ATL",
                "JFK",
                "SFO",
                "ATL",
                "SFO"
            };

            IList<IList<string>> tickets = new List<IList<string>>()
            {
                new List<string>() { "JFK", "SFO" },
                new List<string>() { "JFK", "ATL" },
                new List<string>() { "SFO", "ATL" },
                new List<string>() { "ATL", "JFK" },
                new List<string>() { "ATL", "SFO" }
            };

            Assert.Equal(expected, new Solution().FindItinerary(tickets));
        }

        [Fact]
        public void Test3()
        {
            List<string> expected = new()
            {
                "JFK",
                "SFO",
                "JFK",
                "SEA"
            };

            IList<IList<string>> tickets = new List<IList<string>>()
            {
                new List<string>() { "JFK", "SFO" },
                new List<string>() { "JFK", "SEA" },
                new List<string>() { "SFO", "JFK" }
            };

            Assert.Equal(expected, new Solution().FindItinerary(tickets));
        }
    }
}