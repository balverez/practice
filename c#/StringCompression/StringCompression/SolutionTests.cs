using Xunit;

namespace StringCompression
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            string test = "AAAAaaabbbbbcccc";
            string expectedString = "A4a3b5c4";
            Assert.Equal(expectedString, new Solution().Compress(test));
        }

        [Fact]
        public void Test2()
        {
            string test = "aabbbbccc";
            string expectedString = "a2b4c3";
            Assert.Equal(expectedString, new Solution().Compress(test));
        }

        [Fact]
        public void Test3()
        {
            string test = "abc";
            string expectedString = "abc";
            Assert.Equal(expectedString, new Solution().Compress(test));
        }

        [Fact]
        public void Test4()
        {
            string test = "";
            string expectedString = "";
            Assert.Equal(expectedString, new Solution().Compress(test));
        }
    }
}