namespace ReverseLinkedList
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 5, 4, 3, 2, 1 };
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            List<int> result = ConvertListNodes(new Solution().ReverseList(head));

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new() { 2, 1 };
            ListNode head = new(1, new(2));
            List<int> result = ConvertListNodes(new Solution().ReverseList(head));

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test3()
        {
            List<int> expected = new() { };
            List<int> result = ConvertListNodes(new Solution().ReverseList(null));

            Assert.Equal(expected, result);
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