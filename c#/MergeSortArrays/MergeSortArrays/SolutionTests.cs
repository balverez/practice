using Xunit;

namespace MergeSortArrays
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(
            new int[] { 2, 5, 7, 8, 9 },
            new int[] { 9 },
            new int[] { 2, 5, 7, 8, 9, 9 })]
        [InlineData(
            new int[] { 7, 8 },
            new int[] { 1, 2 },
            new int[] { 1, 2, 7, 8 })]
        [InlineData(
            new int[] { 2 },
            new int[] { },
            new int[] { 2 })]
        [InlineData(
            new int[] { 2, 5, 7, 8 },
            new int[] { 2, 4, 5, 12, 32 },
            new int[] { 2, 2, 4, 5, 5, 7, 8, 12, 32 })]
        public void Test1(int[] arr1, int[] arr2, int[] result)
        {
            Assert.Equal(result, new Solution().MergeSort(arr1, arr2));
        }
    }
}