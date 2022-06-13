namespace WordLadder
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 5;
            string beginWord = "hit";
            string endWord = "cog";
            IList<string> wordList = new List<string>()
            {
                "hot",
                "dot",
                "dog",
                "lot",
                "log",
                "cog"
            };

            Assert.Equal(expected, new Solution().LadderLength(beginWord, endWord, wordList));
        }

        [Fact]
        public void Test2()
        {
            int expected = 0;
            string beginWord = "hit";
            string endWord = "cog";
            IList<string> wordList = new List<string>()
            {
                "hot",
                "dot",
                "dog",
                "lot",
                "log"
            };

            Assert.Equal(expected, new Solution().LadderLength(beginWord, endWord, wordList));
        }
    }
}