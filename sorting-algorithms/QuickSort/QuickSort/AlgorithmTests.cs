using Xunit;

namespace QuickSort
{
    public class AlgorithmTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 2, 8, 7, 1, 3, 5, 6, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 3, 1, 2, 4 })]
        public void Test1(int[] expected, int[] test)
        {
            new Algorithm().QuickSort(test, 0, test.Length - 1);

            Assert.Equal(expected, test);
        }
    }
}