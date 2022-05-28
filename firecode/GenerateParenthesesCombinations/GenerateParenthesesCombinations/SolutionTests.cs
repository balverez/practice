using System.Collections.Generic;
using Xunit;

namespace GenerateParenthesesCombinations
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            HashSet<string> expected = new() { "()" };
            int test = 1;
            Assert.Equal(expected, new Solution().GenerateParenthesis(test));
        }

        [Fact]
        public void Test2()
        {
            HashSet<string> expected = new() { "()()", "(())" };
            int test = 2;
            Assert.Equal(expected, new Solution().GenerateParenthesis(test));
        }
    }
}