using Xunit;

namespace TwoSum
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] testArr = new int[] { 1, 9, 3, 4, 5 };
            int target = 14;
            int[] expectedResult = new int[] { 1, 4 };

            Assert.Equal(expectedResult, Solution.TwoSum(testArr, target));
        }
    }
}