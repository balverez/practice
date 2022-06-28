namespace MergeTripletsToFormTargetTriplet
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            int[][] triplets =
            {
                new int[] { 2, 5, 3 },
                new int[] { 1, 8, 4 },
                new int[] { 1, 7, 5 }
            };
            int[] target = { 2, 7, 5 };

            Assert.Equal(expected, new Solution().MergeTriplets(triplets, target));
        }

        [Fact]
        public void Test2()
        {
            bool expected = false;
            int[][] triplets =
            {
                new int[] { 3, 4, 5 },
                new int[] { 4, 5, 6 }
            };
            int[] target = { 3, 2, 5 };

            Assert.Equal(expected, new Solution().MergeTriplets(triplets, target));
        }

        [Fact]
        public void Test3()
        {
            bool expected = true;
            int[][] triplets =
            {
                new int[] { 2, 5, 3 },
                new int[] { 2, 3, 4 },
                new int[] { 1, 2, 5 },
                new int[] { 5, 2, 3 },
            };
            int[] target = { 5, 5, 5 };

            Assert.Equal(expected, new Solution().MergeTriplets(triplets, target));
        }
    }
}