using Xunit;

namespace MergeSort
{
    public class AlgorithmTests
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 6, 7, 9, 11, 12, 14 }, new int[] { 12, 3, 7, 9, 14, 6, 11, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 3, 1, 2, 4 })]
        public void Test1(int[] expected, int[] test)
        {
            new Algorithm().MergeSort(test);

            Assert.Equal(expected, test);
        }
    }
}