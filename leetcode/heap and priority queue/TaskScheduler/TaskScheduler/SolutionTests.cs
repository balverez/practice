namespace TaskScheduler
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(8, new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2)]
        [InlineData(6, new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 0)]
        [InlineData(16, new char[] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' }, 2)]
        public void Tests(int expected, char[] tasks, int n) => Assert.Equal(expected, new Solution().LeastInterval(tasks, n));
    }
}