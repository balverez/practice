namespace DesignAddAndSearchWordsDataStructure
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            WordDictionary dict = new();
            dict.AddWord("bad");
            dict.AddWord("dad");
            dict.AddWord("mad");

            Assert.False(dict.Search("pad"));
            Assert.True(dict.Search("bad"));
            Assert.True(dict.Search(".ad"));
            Assert.True(dict.Search("b.."));
        }
    }
}