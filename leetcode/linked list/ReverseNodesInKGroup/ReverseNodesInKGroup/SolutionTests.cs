namespace ReverseNodesInKGroup
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 2, 1, 4, 3, 5 };
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            int k = 2;

            Assert.Equal(expected, ConvertListNodes(new Solution().ReverseKGroup(head, k)));
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new() { 3, 2, 1, 4, 5 };
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            int k = 3;

            Assert.Equal(expected, ConvertListNodes(new Solution().ReverseKGroup(head, k)));
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