using Xunit;

namespace LinkedListInsertTail
{
    public class SolutionTests
    {
        [Fact]
        public void InsertTest()
        {
            ListNode testRoot = new(1, new(2));
            int test = 3;
            testRoot = new Solution().InsertTail(testRoot, test);
            
            Assert.Equal(test, testRoot.Next?.Next?.Data);
        }

        [Fact]
        public void NullTest()
        {
            ListNode head = new Solution().InsertTail(null, 1);
            Assert.NotNull(head);
        }
    }
}