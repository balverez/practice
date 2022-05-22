namespace LinkedListReversal
{
    internal class ListNode
    {
        internal int Data { get; set; }
        internal ListNode? Next { get; set; } = null;

        internal ListNode(int data, ListNode? next)
        {
            Data = data;
            Next = next;
        }

        internal ListNode(int data) => Data = data;
    }
}