namespace GasStation
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 })]
        [InlineData(-1, new int[] { 2, 3, 4 }, new int[] { 3, 4, 3 })]
        [InlineData(0, new int[] { 3, 1, 1 }, new int[] { 1, 2, 2 })]
        public void Tests(int expected, int[] gas, int[] cost) => Assert.Equal(expected, new Solution().CanCompleteCircuit(gas, cost));
    }
}