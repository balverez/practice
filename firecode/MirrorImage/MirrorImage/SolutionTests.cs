using Xunit;

namespace MirrorImage
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[,] test = new int[2,3] { { 255, 0, 0 }, { 255, 0, 0 } };
            int[,] expectedResult = new int[2,3] { { 0, 0, 255 }, { 0, 0, 255 } };
            Assert.Equal(new Solution().MirrorImage(test), expectedResult);
        }

        [Fact]
        public void Test2()
        {
            int[,] test = new int[2, 3] { { 255, 255, 0 }, { 255, 255, 0 } };
            int[,] expectedResult = new int[2, 3] { { 0, 255, 255 }, { 0, 255, 255 } };
            Assert.Equal(new Solution().MirrorImage(test), expectedResult);
        }

        [Fact]
        public void Test3()
        {
            int[,] test = new int[1, 2] { { 255, 0 } };
            int[,] expectedResult = new int[1, 2] { { 0, 255 } };
            Assert.Equal(new Solution().MirrorImage(test), expectedResult);
        }
    }
}