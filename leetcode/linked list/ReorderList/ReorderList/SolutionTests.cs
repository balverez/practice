namespace ReorderList
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 1, 4, 2, 3 };
            ListNode head = new(1, new(2, new(3, new(4))));

            new Solution().ReorderList(head);
            Assert.Equal(expected, ConvertListNodes(head));
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new() { 1, 5, 2, 4, 3 };
            ListNode head = new(1, new(2, new(3, new(4,  new(5)))));

            new Solution().ReorderList(head);
            Assert.Equal(expected, ConvertListNodes(head));
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