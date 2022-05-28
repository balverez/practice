using Xunit;

namespace DetectMiddleLinkedList
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            ListNode head = new(1);
            Assert.Equal(1, new Solution().FindMiddle(head));
        }

        [Fact]
        public void Test2()
        {
            ListNode node = new(3);
            ListNode middle = new ListNode(2, node);
            ListNode head = new ListNode(1, middle);

            Assert.Equal(2, new Solution().FindMiddle(head));
        }

        [Fact]
        public void Test3()
        {
            ListNode node1 = new(4);
            ListNode middle = new(3, node1);
            ListNode node2 = new ListNode(2, middle);
            ListNode head = new ListNode(1, node2);

            Assert.Equal(3, new Solution().FindMiddle(head));
        }

        [Fact]
        public void Test4()
        {
            ListNode node1 = new(5);
            ListNode node2 = new(4, node1);
            ListNode middle = new(3, node2);
            ListNode node3 = new ListNode(2, middle);
            ListNode head = new ListNode(1, node3);

            Assert.Equal(3, new Solution().FindMiddle(head));
        }
    }
}