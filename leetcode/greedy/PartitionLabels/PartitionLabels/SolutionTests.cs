namespace PartitionLabels
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            List<int> expected = new() { 9, 7, 8 };
            string s = "ababcbacadefegdehijhklij";

            Assert.Equal(expected, new Solution().PartitionLabels(s));
        }

        [Fact]
        public void Test2()
        {
            List<int> expected = new() { 10 };
            string s = "eccbbbbdec";

            Assert.Equal(expected, new Solution().PartitionLabels(s));
        }
    }
}