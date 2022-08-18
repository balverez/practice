namespace LRUCache
{
    //O(n) space
    public class LRUCache
    {
        public int Capacity { get; set; }
        public Dictionary<int, Node> Cache { get; set; } = new();
        public Node Left { get; set; } = new(int.MinValue, int.MinValue);
        public Node Right { get; set; } = new(int.MaxValue, int.MaxValue);

        public LRUCache(int capacity)
        {
            Capacity = capacity;
            Left.Next = Right;
            Right.Previous = Left;
        }

        //O(1) time
        public int Get(int key)
        {
            if (Cache.ContainsKey(key))
            {
                Remove(Cache[key]);
                Insert(Cache[key]);
                return Cache[key].Value;
            }

            return -1;
        }

        //O(1) time
        public void Put(int key, int value)
        {
            if (Cache.ContainsKey(key))
                Remove(Cache[key]);

            Cache[key] = new(key, value);
            Insert(Cache[key]);

            if (Cache.Count > Capacity)
            {
                Node lru = Left.Next;
                Remove(lru);
                Cache.Remove(lru.Key);
            }
        }

        //O(1) time
        private void Insert(Node mru)
        {
            mru.Next = Right;
            mru.Previous = Right.Previous;
            Right.Previous.Next = Right.Previous = mru;
        }

        //O(1) time
        private void Remove(Node node)
        {
            node.Previous.Next = node.Next;
            node.Next.Previous = node.Previous;
        }
    }
}