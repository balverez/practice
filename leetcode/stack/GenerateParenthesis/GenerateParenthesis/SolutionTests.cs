namespace GenerateParenthesis
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<string> expected = new()
            {
                "((()))",
                "(()())",
                "()(())",
                "(())()",
                "()()()",
            };

            int n = 3;

            Assert.Equal(expected, new Solution().GenerateParenthesis(n));
        }

        [Fact]
        public void Test2()
        {
            List<string> expected = new() { "()" };

            int n = 1;

            Assert.Equal(expected, new Solution().GenerateParenthesis(n));
        }
    }
}