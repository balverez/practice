using Xunit;

namespace BoggleWordFinder
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(true, "HELLO")]
        [InlineData(false, "ALOHA")]
        public void Test1(bool expected, string test)
        {
            char[,] testBoard = new char[,]
            {
                { 'A', 'O', 'L' },
                { 'D', 'E', 'L' },
                { 'G', 'H', 'I' },
            };

            Assert.Equal(expected, new Solution().FindWord(testBoard, test));
        }
    }
}