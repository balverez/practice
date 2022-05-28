using Xunit;

namespace DoublyLinkedListInsertHead
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            DoublyLinkedListNode testHead = new DoublyLinkedListNode(1);
            testHead.Next = new DoublyLinkedListNode(2, testHead, null);
            int test = -1;
            Assert.Equal(test, new Solution().InsertHead(testHead, test).Data);
        }

        [Fact]
        public void Test2()
        {
            int test = -1;
            Assert.Equal(test, new Solution().InsertHead(null, test).Data);
        }
    }
}