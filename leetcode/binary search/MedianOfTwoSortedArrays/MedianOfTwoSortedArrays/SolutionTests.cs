namespace MedianOfTwoSortedArrays
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(2, new int[] { 1, 3 }, new int[] { 2 })]
        [InlineData(2.5, new int[] { 1, 2 }, new int[] { 3, 4 })]
        [InlineData(1, new int[] { 3, 4 }, new int[] { 1, 1, 1, 1, 1 })]
        [InlineData(1, new int[] { 3, 4 }, new int[] { 1, 1, 1, 1 })]
        public void Tests(double expected, int[] nums1, int[] nums2) => Assert.Equal(expected, new Solution().FindMedianSortedArrays(nums1, nums2));
    }
}