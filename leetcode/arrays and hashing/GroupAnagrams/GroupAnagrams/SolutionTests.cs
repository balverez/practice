namespace GroupAnagrams
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<IList<string>> expected = new()
            {
                new List<string>() { "eat", "tea", "ate" },
                new List<string>() { "tan", "nat" },
                new List<string>() { "bat" }
            };

            string[] strs =
            {
                "eat",
                "tea",
                "tan",
                "ate",
                "nat",
                "bat"
            };

            Assert.Equal(expected, new Solution().GroupAnagrams(strs));
        }

        [Fact]
        public void Test2()
        {
            List<IList<string>> expected = new()
            {
                new List<string>() { string.Empty }
            };

            string[] strs = { string.Empty };

            Assert.Equal(expected, new Solution().GroupAnagrams(strs));
        }

        [Fact]
        public void Test3()
        {
            List<IList<string>> expected = new()
            {
                new List<string>(){ "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" },
                new List<string>(){ "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa" }
            };

            string[] strs =
            {
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
            };

            Assert.Equal(expected, new Solution().GroupAnagrams(strs));
        }
    }
}