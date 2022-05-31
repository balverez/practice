namespace SurroundedRegions
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            char[][] expected = new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'O', 'X', 'X' }
            };
            
            char[][] test = new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'O', 'O', 'X' },
                new char[] { 'X', 'X', 'O', 'X' },
                new char[] { 'X', 'O', 'X', 'X' }
            };

            new Solution().Solve(test);
            Assert.Equal(expected, test);
        }

        [Fact]
        public void Test2()
        {
            char[][] expected = new char[][]
            {
                new char[] { 'X' }
            };

            char[][] test = new char[][]
            {
                new char[] { 'X' }
            };

            new Solution().Solve(test);
            Assert.Equal(expected, test);
        }

        [Fact]
        public void Test3()
        {
            char[][] expected = new char[][]
            {
                new char[] { 'O', 'O' },
                new char[] { 'O', 'O' }
            };

            char[][] test = new char[][]
            {
                new char[] { 'O', 'O' },
                new char[] { 'O', 'O' }
            };

            new Solution().Solve(test);
            Assert.Equal(expected, test);
        }
    }
}