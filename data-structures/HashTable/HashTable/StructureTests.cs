using Xunit;

namespace HashTable
{
    public class StructureTests
    {
        private const int _size = 2;
        private readonly HashTable _hashTable = new(_size);

        public StructureTests()
        {
            _hashTable.Insert("Rosa", 0);
            _hashTable.Insert("Arturo", 1);
            _hashTable.Insert("Juan", 2);
            _hashTable.Insert("Leticia", 3);
            _hashTable.Insert("Yuly", 4);
            _hashTable.Insert("Yesenia", 5);
        }

        [Theory]
        [InlineData(0, "Rosa")]
        [InlineData(1, "Arturo")]
        [InlineData(2, "Juan")]
        [InlineData(3, "Leticia")]
        [InlineData(4, "Yuly")]
        [InlineData(5, "Yesenia")]
        public void Test1(int expected, string test)
        {
            Assert.Equal(expected, _hashTable.Search(test));
        }

        [Fact]
        public void Test2()
        {
            _hashTable.Delete("Rosa");

            Assert.Null(_hashTable.Search("Rosa"));
        }
    }
}