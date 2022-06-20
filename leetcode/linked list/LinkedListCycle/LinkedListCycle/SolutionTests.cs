namespace LinkedListCycle
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            ListNode head = new(3, new(2, new(0, new(4))));

            Assert.Equal(expected, new Solution().HasCycle(head));
        }

        [Fact]
        public void Test2()
        {
            bool expected = true;
            ListNode head = new(1, new(2));
            head.next.next = head;

            Assert.Equal(expected, new Solution().HasCycle(head));
        }

        [Fact]
        public void Test3()
        {
            bool expected = false;
            ListNode head = new(1);

            Assert.Equal(expected, new Solution().HasCycle(head));
        }
    }
}