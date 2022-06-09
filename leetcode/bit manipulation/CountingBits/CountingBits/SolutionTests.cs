namespace CountingBits
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] expected = { 0, 1, 1 };
            int n = 2;

            Assert.Equal(expected, new Solution().CountBits(n));
        }

        [Fact]
        public void Test2()
        {
            int[] expected = { 0, 1, 1, 2, 1, 2 };
            int n = 5;

            Assert.Equal(expected, new Solution().CountBits(n));
        }

        [Fact]
        public void Test3()
        {
            int[] expected = { 0, 1, 1, 2, 1, 2, 2, 3, 1 };
            int n = 8;

            Assert.Equal(expected, new Solution().CountBits(n));
        }
    }
}