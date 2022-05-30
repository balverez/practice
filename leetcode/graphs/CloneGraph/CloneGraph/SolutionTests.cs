namespace CloneGraph
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            Node one = new(1);
            Node two = new(2);
            Node three = new(3);
            Node four = new(4);

            one.neighbors.Add(two);
            one.neighbors.Add(four);
            two.neighbors.Add(one);
            two.neighbors.Add(three);
            three.neighbors.Add(two);
            three.neighbors.Add(four);
            four.neighbors.Add(one);
            four.neighbors.Add(three);

            Node? clone = new Solution().CloneGraph(one);
            Assert.Equal(one.val, clone.val);
            Assert.Equal(one.neighbors.Count, clone.neighbors.Count);
            Assert.Equal(one.neighbors.Any(x => x.val == 2), clone.neighbors.Any(x => x.val == 2));
            Assert.Equal(one.neighbors.Any(x => x.val == 4), clone.neighbors.Any(x => x.val == 4));
        }
    }
}