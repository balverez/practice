namespace WordSearch
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            char[][] board =
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };
            string word = "ABCCED";

            Assert.Equal(expected, new Solution().Exist(board, word));
        }

        [Fact]
        public void Test2()
        {
            bool expected = true;
            char[][] board =
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };
            string word = "SEE";

            Assert.Equal(expected, new Solution().Exist(board, word));
        }

        [Fact]
        public void Test3()
        {
            bool expected = false;
            char[][] board =
            {
                new char[] { 'A', 'B', 'C', 'E' },
                new char[] { 'S', 'F', 'C', 'S' },
                new char[] { 'A', 'D', 'E', 'E' }
            };
            string word = "ABCB";

            Assert.Equal(expected, new Solution().Exist(board, word));
        }
    }
}