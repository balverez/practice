namespace CopyListWithRandomPointer
{
    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null)
                return head;

            Node? iterator = head;
            while (iterator != null)
            {
                Node copy = new(iterator.val);
                copy.next = iterator.next;
                iterator.next = copy;
                iterator = copy.next;
            }

            iterator = head;
            while (iterator != null)
            {
                if (iterator.random != null)
                    iterator.next.random = iterator.random.next;

                iterator = iterator.next.next;
            }

            iterator = head;
            Node? copyIterator = head.next;
            Node? oldHead = head.next;
            while (iterator != null)
            {
                iterator.next = iterator.next.next;
                copyIterator.next = (copyIterator.next != null ? copyIterator.next.next : null);
                iterator = iterator.next;
                copyIterator = copyIterator.next;
            }

            return oldHead;
        }
    }
}