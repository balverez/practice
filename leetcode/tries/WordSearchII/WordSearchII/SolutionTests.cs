namespace WordSearchII
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<string> expected = new()
            {
                "oath",
                "eat"
            };
            char[][] board =
            {
                new char[] { 'o', 'a', 'a', 'n' },
                new char[] { 'e', 't', 'a', 'e' },
                new char[] { 'i', 'h', 'k', 'r' },
                new char[] { 'i', 'f', 'l', 'v' }
            };
            string[] words = { "oath", "pea", "eat", "rain" };

            Assert.Equal(expected, new Solution().FindWords(board, words));
        }

        [Fact]
        public void Test2()
        {
            List<string> expected = new();
            char[][] board =
            {
                new char[] { 'a', 'b' },
                new char[] { 'c', 'd' }
            };
            string[] words = { "abcb" };

            Assert.Equal(expected, new Solution().FindWords(board, words));
        }

        [Fact]
        public void Test3()
        {
            List<string> expected = new()
            {
                "oat",
                "oath",
                "eat"
            };
            char[][] board =
            {
                new char[] { 'o', 'a', 'a', 'n' },
                new char[] { 'e', 't', 'a', 'e' },
                new char[] { 'i', 'h', 'k', 'r' },
                new char[] { 'i', 'f', 'l', 'v' }
            };
            string[] words = { "oath", "pea", "eat", "rain", "oat" };

            Assert.Equal(expected, new Solution().FindWords(board, words));
        }

        [Fact]
        public void Test4()
        {
            List<string> expected = new()
            {
                "oath",
                "eat",
                "hf",
                "hklf"
            };
            char[][] board =
            {
                new char[] { 'o', 'a', 'a', 'n' },
                new char[] { 'e', 't', 'a', 'e' },
                new char[] { 'i', 'h', 'k', 'r' },
                new char[] { 'i', 'f', 'l', 'v' }
            };
            string[] words = { "oath", "pea", "eat", "rain", "hklf", "hf" };

            Assert.Equal(expected, new Solution().FindWords(board, words));
        }
    }
}