namespace MinStack
{
    //O(n) space
    public class MinStack
    {
        private int _min;
        private int _length;
        private List<(int, int)> _entries;

        public MinStack()
        {
            _min = int.MaxValue;
            _length = 0;
            _entries = new();
        }

        //O(1) time
        //O(1) space
        public void Push(int val)
        {
            _min = Math.Min(_min, val);
            _entries.Add((val, _min));
            _length++;
        }

        //O(1) time
        //O(1) space
        public void Pop()
        {
            _entries.RemoveAt(_length - 1);
            _length--;
            _min = _length > 0 ? _entries[_length - 1].Item2 : int.MaxValue;
        }

        //O(1) time
        //O(1) space
        public int Top()
        {
            return _entries[_length - 1].Item1;
        }

        //O(1) time
        //O(1) space
        public int GetMin()
        {
            return _min;
        }
    }
}