namespace BinarySearch
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(4, new int[] { -1, 0, 3, 5, 9, 12 }, 9)]
        [InlineData(-1, new int[] { -1, 0, 3, 5, 9, 12 }, 2)]
        [InlineData(5, new int[] { -1, 0, 3, 5, 9, 12 }, 12)]
        [InlineData(-1, new int[] { -1, 0, 3, 5, 9, 12 }, 13)]
        [InlineData(0, new int[] { -1, 0, 3, 5, 9, 12 }, -1)]
        public void Test1(int expected, int[] nums, int target) => Assert.Equal(expected, new Solution().Search(nums, target));
    }
}