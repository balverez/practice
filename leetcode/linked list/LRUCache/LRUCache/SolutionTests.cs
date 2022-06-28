namespace LRUCache
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            LRUCache lruCache = new(2);
            lruCache.Put(1, 1);
            lruCache.Put(2, 2);
            Assert.Equal(1, lruCache.Get(1));
            lruCache.Put(3, 3);
            Assert.Equal(-1, lruCache.Get(2));
            lruCache.Put(4, 4);
            Assert.Equal(-1, lruCache.Get(1));
            Assert.Equal(3, lruCache.Get(3));
            Assert.Equal(4, lruCache.Get(4));
        }
    }
}