using Xunit;

namespace StringPermutationsCombinations
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new string[] { }, "")]
        [InlineData(new string[] { "A" }, "A")]
        [InlineData(new string[] { "A", "B", "AB", "BA" }, "AB")]
        [InlineData(new string[] { "A", "B", "C", "AB", "BA", "AC", "CA", "BC", "CB", "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" }, "ABC")]
        public void Test1(string[] expected, string test)
        {
            Assert.Equal(new HashSet<string>(expected), new Solution().PermutationsAndCombinations(test));
        }
    }
}