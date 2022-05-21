namespace HashTable
{
    internal class Map
    {
        internal string Key { get; set; }
        internal int Value { get; set; }

        internal Map(string key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}