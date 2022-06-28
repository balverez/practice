namespace TimeBasedKeyValueStore
{
    public class TimeMap
    {
        private Dictionary<string, List<(string, int)>> _keys = new();

        //O(n) time
        //O(n) space
        public void Set(string key, string value, int timestamp)
        {
            if (!_keys.ContainsKey(key))
                _keys[key] = new();

            _keys[key].Add((value, timestamp));
        }

        //O(logn) time
        //O(1) space
        public string Get(string key, int timestamp)
        {
            if (!_keys.ContainsKey(key))
                return string.Empty;

            List<(string, int)> list = _keys[key];
            int left = 0;
            int right = list.Count - 1;

            if (list.Count == 1)
                return list[0].Item1;

            if (timestamp < list[left].Item2)
                return string.Empty;

            if (timestamp > list[right].Item2)
                return list[right].Item1;

            while (left <= right)
            {
                int p = left + right / 2;
                int pt = list[p].Item2;

                if (timestamp == pt)
                    return list[p].Item1;

                if (timestamp < pt)
                    right = p - 1;
                else
                    left = p + 1;
            }

            return list[right].Item1;
        }
    }
}