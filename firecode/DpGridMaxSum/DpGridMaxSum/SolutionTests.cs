using Xunit;

namespace DpGridMaxSum
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 29;
            int[,] test = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Assert.Equal(expected, new Solution().MaxSumDp(test));
        }
    }
}