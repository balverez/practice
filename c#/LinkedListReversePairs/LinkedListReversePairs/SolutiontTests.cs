using Xunit;

namespace LinkedListReversePairs
{
    public class SolutiontTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 1;
            ListNode test = new(1, new(2));

            Assert.Equal(expected, new Solution().ReverseInPairs(test)?.Next?.Data);
        }

        [Fact]
        public void Test2()
        {
            int expected = 3;
            ListNode test = new(1, new(2, new(3)));

            Assert.Equal(expected, new Solution().ReverseInPairs(test)?.Next?.Next?.Data);
        }

        [Fact]
        public void Test3()
        {
            int expected = 6;
            ListNode test = new(1, new(2, new(3, new(4, new(5, new(6))))));

            Assert.Equal(expected, new Solution().ReverseInPairs(test)?.Next?.Next?.Next?.Next?.Data);
        }
    }
}