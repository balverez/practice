namespace RemoveNthNodeFromEndOfList
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 1, 2, 3, 5 };
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            int n = 2;

            Assert.Equal(expected, ConvertListNodes(new Solution().RemoveNthFromEnd(head, n)));
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new();
            ListNode head = new(1);
            int n = 1;

            Assert.Equal(expected, ConvertListNodes(new Solution().RemoveNthFromEnd(head, n)));
        }

        [Fact]
        public void Test3()
        {
            List<int> expected = new() { 1 };
            ListNode head = new(1, new(2));
            int n = 1;

            Assert.Equal(expected, ConvertListNodes(new Solution().RemoveNthFromEnd(head, n)));
        }

        private List<int> ConvertListNodes(ListNode? head)
        {
            List<int> result = new();

            while (head != null)
            {
                result.Add(head.val);
                head = head.next;
            }

            return result;
        }
    }
}