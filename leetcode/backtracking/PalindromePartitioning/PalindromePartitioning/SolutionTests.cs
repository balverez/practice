namespace PalindromePartitioning
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<IList<string>> expected = new()
            {
                new List<string>() { "a", "a", "b" },
                new List<string>() { "aa", "b" }
            };
            string s = "aab";

            Assert.Equal(expected, new Solution().Partition(s));
        }

        [Fact]
        public void Test2()
        {
            List<IList<string>> expected = new()
            {
                new List<string>() { "a" }
            };
            string s = "a";

            Assert.Equal(expected, new Solution().Partition(s));
        }

        [Fact]
        public void Test3()
        {
            List<IList<string>> expected = new()
            {
                new List<string>() { "a", "a", "a", "b" },
                new List<string>() { "a", "aa", "b" },
                new List<string>() { "aa", "a", "b" },
                new List<string>() { "aaa", "b" }
            };
            string s = "aaab";

            Assert.Equal(expected, new Solution().Partition(s));
        }
    }
}