namespace MultiplyStrings
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("6", "2", "3")]
        [InlineData("56088", "123", "456")]
        public void Tests(string expected, string num1, string num2) => Assert.Equal(expected, new Solution().Multiply(num1, num2));
    }
}