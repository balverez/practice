namespace PartitionEqualSubsetSum
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, new int[] { 1, 5, 11, 5 })]
        [InlineData(false, new int[] { 1, 2, 3, 5 })]
        public void Tests(bool expected, int[] nums) => Assert.Equal(expected, new Solution().CanPartition(nums));
    }
}