namespace EvaluateReversePolishNotation
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(9, new string[] { "2", "1", "+", "3", "*" })]
        [InlineData(6, new string[] { "4", "13", "5", "/", "+" })]
        [InlineData(1, new string[] { "4", "3", "-" })]
        [InlineData(22, new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" })]
        public void Tests(int expected, string[] tokens) => Assert.Equal(expected, new Solution().EvalRPN(tokens));
    }
}