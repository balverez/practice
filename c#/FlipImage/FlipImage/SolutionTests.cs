using Xunit;

namespace FlipImage
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            int[,] testArr = new int[,]
            { 
                { 255, 0, 0 },
                { 0, 0, 255 }
            };
            
            int[,] expectedArr = new int[,]
            { 
                { 0, 0, 255 },
                { 255, 0, 0 }
            };

            Assert.Equal(new Solution().FlipImage(testArr), expectedArr);
        }

        [Fact]
        public void Test2()
        {
            int[,] testArr = new int[,]
            { 
                { 255, 255, 255 },
                { 0, 0, 0 } 
            };
            
            int[,] expectedResult = new int[,]
            { 
                { 0, 0, 0 }, 
                { 255, 255, 255 }
            };

            Assert.Equal(new Solution().FlipImage(testArr), expectedResult);
        }

        [Fact]
        public void Test3()
        {
            int[,] testArr = new int[,]
            {
                { 255, 255, 255 }
            };

            int[,] expectedResult = new int[,]
            {
                { 255, 255, 255 }
            };

            Assert.Equal(new Solution().FlipImage(testArr), expectedResult);
        }
    }
}