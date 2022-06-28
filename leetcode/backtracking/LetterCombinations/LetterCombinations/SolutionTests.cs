namespace LetterCombinations
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<string> expected = new()
            {
                "ad",
                "ae",
                "af",
                "bd",
                "be",
                "bf",
                "cd",
                "ce",
                "cf"
            };
            string digits = "23";

            Assert.Equal(expected, new Solution().LetterCombinations(digits));
        }

        [Fact]
        public void Test2()
        {
            List<string> expected = new() { "" };
            string digits = "";

            Assert.Equal(expected, new Solution().LetterCombinations(digits));
        }

        [Fact]
        public void Test3()
        {
            List<string> expected = new() { "a", "b", "c" };
            string digits = "2";

            Assert.Equal(expected, new Solution().LetterCombinations(digits));
        }
    }
}