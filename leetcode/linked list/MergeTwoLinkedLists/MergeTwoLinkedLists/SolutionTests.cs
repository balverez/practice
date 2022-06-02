namespace MergeTwoLinkedLists
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 1, 1, 2, 3, 4, 4 };
            ListNode list1 = new(1, new(2, new(4)));
            ListNode list2 = new(1, new(3, new(4)));

            Assert.Equal(expected, ConvertListNodes(new Solution().MergeTwoLists(list1, list2)));
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new() { };
            ListNode? list1 = null;
            ListNode? list2 = null;

            Assert.Equal(expected, ConvertListNodes(new Solution().MergeTwoLists(list1, list2)));
        }

        [Fact]
        public void Test3()
        {
            List<int> expected = new() { 0 };
            ListNode? list1 = null;
            ListNode? list2 = new(0);

            Assert.Equal(expected, ConvertListNodes(new Solution().MergeTwoLists(list1, list2)));
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