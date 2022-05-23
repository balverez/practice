using System.Collections.Generic;
using Xunit;

namespace StringPermutations
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            HashSet<string> expected = new();
            string test = "";

            Assert.Equal(expected, new Solution().Permutations(test));
        }

        [Fact]
        public void Test2()
        {
            HashSet<string> expected = new()
            {
                "A"
            };
            string test = "A";

            Assert.Equal(expected, new Solution().Permutations(test));
        }

        [Fact]
        public void Test3()
        {
            HashSet<string> expected = new()
            {
                "AB",
                "BA"
            };
            string test = "AB";

            Assert.Equal(expected, new Solution().Permutations(test));
        }

        [Fact]
        public void Test4()
        {
            HashSet<string> expected = new()
            {
                "ABC",
                "ACB",
                "BAC",
                "BCA",
                "CAB",
                "CBA"
            };
            string test = "ABC";

            Assert.Equal(expected, new Solution().Permutations(test));
        }

        [Fact]
        public void Test5()
        {
            HashSet<string> expected = new()
            {
                "ABCD",
                "ABDC",
                "ACBD",
                "ACDB",
                "ADBC",
                "ADCB",
                "BACD",
                "BADC",
                "BCAD",
                "BCDA",
                "BDAC",
                "BDCA",
                "CABD",
                "CADB",
                "CBAD",
                "CBDA",
                "CDAB",
                "CDBA",
                "DABC",
                "DACB",
                "DBAC",
                "DBCA",
                "DCAB",
                "DCBA"
            };
            string test = "ABCD";

            Assert.Equal(expected, new Solution().Permutations(test));
        }
    }
}