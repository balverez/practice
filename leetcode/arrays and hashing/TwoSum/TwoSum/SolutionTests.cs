namespace TwoSum
{
    public class SolutionTests

    {
        [Theory]
        [InlineData(new int[] { 0, 1 }, new int[] { 2, 7, 11, 15 }, 9)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 2, 4 }, 6)]
        [InlineData(new int[] { 0, 1 }, new int[] { 3, 3 }, 6)]
        public void Test(int[] expectedArr, int[] nums, int target)
        {
            List<int> expected = new(expectedArr);

            Assert.Equal(expected, new Solution().TwoSum(nums, target));
        }
    }
}