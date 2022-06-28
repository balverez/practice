namespace TimeBasedKeyValueStore
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            TimeMap map = new();
            map.Set("foo", "bar", 1);
            Assert.Equal("bar", map.Get("foo", 1));
            Assert.Equal("bar", map.Get("foo", 3));

            map.Set("foo", "bar2", 4);
            Assert.Equal("bar2", map.Get("foo", 4));
            Assert.Equal("bar2", map.Get("foo", 5));
        }

        [Fact]
        public void Test2()
        {
            TimeMap map = new();
            map.Set("love", "high", 10);
            map.Set("love", "low", 20);
            Assert.Equal(string.Empty, map.Get("love", 5));
            Assert.Equal("high", map.Get("love", 10));
            Assert.Equal("high", map.Get("love", 15));
            Assert.Equal("low", map.Get("love", 20));
            Assert.Equal("low", map.Get("love", 25));
        }
    }
}