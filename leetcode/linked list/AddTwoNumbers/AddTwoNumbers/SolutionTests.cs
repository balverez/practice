namespace AddTwoNumbers
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            ListNode expected = new(7, new(0, new(8)));
            ListNode l1 = new(2, new(4, new(3)));
            ListNode l2 = new(5, new(6, new(4)));

            Assert.Equal(ConvertListNodes(expected), ConvertListNodes(new Solution().AddTwoNumbers(l1, l2)));
        }

        [Fact]
        public void Test2()
        {
            ListNode expected = new(0);
            ListNode l1 = new(0);
            ListNode l2 = new(0);

            Assert.Equal(ConvertListNodes(expected), ConvertListNodes(new Solution().AddTwoNumbers(l1, l2)));
        }

        [Fact]
        public void Test3()
        {
            ListNode expected = new(8, new(9, new(9, new(9, new(0, new(0, new(0, new(1))))))));
            ListNode l1 = new(9, new(9, new(9, new(9, new(9, new(9, new(9)))))));
            ListNode l2 = new ListNode(9, new(9, new(9, new(9))));

            Assert.Equal(ConvertListNodes(expected), ConvertListNodes(new Solution().AddTwoNumbers(l1, l2)));
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