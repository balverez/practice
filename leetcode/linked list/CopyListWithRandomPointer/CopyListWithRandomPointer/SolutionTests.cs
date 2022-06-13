namespace CopyListWithRandomPointer
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            Node expected = new(7);
            expected.next = new(13);
            expected.next.random = expected;
            expected.next.next = new(11);
            expected.next.next.next = new(10);
            expected.next.next.next.random = expected.next.next;
            expected.next.next.next.next = new(1);
            expected.next.next.next.next.random = expected;
            expected.next.next.random = expected.next.next.next.next;

            Node head = new(7);
            head.next = new(13);
            head.next.random = head;
            head.next.next = new(11);
            head.next.next.next = new(10);
            head.next.next.next.random = head.next.next;
            head.next.next.next.next = new(1);
            head.next.next.next.next.random = head;
            head.next.next.random = head.next.next.next.next;

            Node result = new Solution().CopyRandomList(head);
            Assert.Equal(expected.val, result.val);
            Assert.Equal(expected.next.next.random.val, result.next.next.random.val);
            Assert.Equal(expected.next.next.next.next.random.val, result.next.next.next.next.random.val);
        }

        [Fact]
        public void Test2()
        {
            Node expected = new(1);
            expected.next = new(2);
            expected.random = expected.next;
            expected.next.random = expected.next;

            Node head = new(1);
            head.next = new(2);
            head.random = head.next;
            head.next.random = head.next;

            Node result = new Solution().CopyRandomList(head);
            Assert.Equal(expected.val, result.val);
            Assert.Equal(expected.next.val, result.next.val);
            Assert.Equal(expected.next.random.val, result.next.random.val);
        }

        [Fact]
        public void Test3()
        {
            Node expected = new(3);
            expected.next = new(3);
            expected.next.random = expected;
            expected.next.next = new(3);

            Node head = new(3);
            head.next = new(3);
            head.next.random = head;
            head.next.next = new(3);

            Node result = new Solution().CopyRandomList(head);
            Assert.Equal(expected.val, result.val);
            Assert.Equal(expected.next.next.next, result.next.next.next);
            Assert.Equal(expected.next.next.random, result.next.next.random);
        }
    }
}