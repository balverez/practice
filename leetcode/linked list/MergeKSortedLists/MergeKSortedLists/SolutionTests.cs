namespace MergeKSortedLists
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 1, 1, 2, 3, 4, 4, 5, 6 };
            ListNode[] lists =
            {
                new(1, new(4, new(5))),
                new(1, new(3, new(4))),
                new(2, new(6)),
            };

            Assert.Equal(expected, ConvertListNodes(new Solution().MergeKLists(lists)));
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new();
            ListNode[] lists = Array.Empty<ListNode>();

            Assert.Equal(expected, ConvertListNodes(new Solution().MergeKLists(lists)));
        }

        [Fact]
        public void Test3()
        {
            List<int> expected = new();
            ListNode?[] lists = { null };

            Assert.Equal(expected, ConvertListNodes(new Solution().MergeKLists(lists)));
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