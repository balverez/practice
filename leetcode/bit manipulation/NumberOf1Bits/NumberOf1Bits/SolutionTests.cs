using System.Text;

namespace NumberOf1Bits
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 3;
            int n = 0b00000000000000000000000000001011;
            Assert.Equal(expected, new Solution().HammingWeight(n));
        }

        [Fact]
        public void Test2()
        {
            int expected = 1;
            int n = 0b00000000000000000000000010000000;
            Assert.Equal(expected, new Solution().HammingWeight(n));
        }

        [Fact]
        public void Test3()
        {
            int expected = 31;
            int n = 0b01111111111111111111111111111111;
            Assert.Equal(expected, new Solution().HammingWeight(n));
        }
    }
}