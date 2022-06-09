namespace PlusOne
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] expected = { 1, 2, 4 };
            int[] digits = { 1, 2, 3 };

            Assert.Equal(expected, new Solution().PlusOne(digits));
        }

        [Fact]
        public void Test2()
        {
            int[] expected = { 4, 3, 2, 2 };
            int[] digits = { 4, 3, 2, 1 };

            Assert.Equal(expected, new Solution().PlusOne(digits));
        }

        [Fact]
        public void Test3()
        {
            int[] expected = { 1, 0 };
            int[] digits = { 9 };

            Assert.Equal(expected, new Solution().PlusOne(digits));
        }

        [Fact]
        public void Test4()
        {
            int[] expected = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 1 };
            int[] digits = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            Assert.Equal(expected, new Solution().PlusOne(digits));
        }
    }
}