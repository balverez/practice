namespace WordBreak
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            string s = "leetcode";
            List<string> wordDict = new()
            {
                "leet",
                "code"
            };

            Assert.Equal(expected, new Solution().WordBreak(s, wordDict));
        }

        [Fact]
        public void Test2()
        {
            bool expected = true;
            string s = "applepenapple";
            List<string> wordDict = new()
            {
                "apple",
                "pen"
            };

            Assert.Equal(expected, new Solution().WordBreak(s, wordDict));
        }

        [Fact]
        public void Test3()
        {
            bool expected = false;
            string s = "catsandog";
            List<string> wordDict = new()
            {
                "cats",
                "dog",
                "sand",
                "and",
                "cat"
            };

            Assert.Equal(expected, new Solution().WordBreak(s, wordDict));
        }
    }
}