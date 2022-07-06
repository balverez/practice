namespace NQueens
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<IList<string>> expected = new()
            {
                new List<string>()
                {
                    ".Q..",
                    "...Q",
                    "Q...",
                    "..Q."
                },
                new List<string>()
                {
                    "..Q.",
                    "Q...",
                    "...Q",
                    ".Q.."
                }
            };
            int n = 4;

            Assert.Equal(expected, new Solution().SolveNQueens(n));
        }

        [Fact]
        public void Test2()
        {
            List<IList<string>> expected = new()
            {
                new List<string>()
                {
                    "Q"
                }
            };
            int n = 1;

            Assert.Equal(expected, new Solution().SolveNQueens(n));
        }
    }
}