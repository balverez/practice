namespace KClosestPointsToOrigin
{
    public class SolutionTests
    {
        [Fact]
        public void Test()
        {
            int[][] expected = new int[][] { new int[] { -2, 2 } };
            int[][] points = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { -2, 2 }
            };
            int k = 1;

            Assert.Equal(expected, new Solution().KClosest(points, k));
        }

        [Fact]
        public void Test2()
        {
            int[][] expected = new int[][]
            { 
                new int[] { 3, 3 },
                new int[] { -2, 4 }
            };
            int[][] points = new int[][]
            {
                new int[] { 3, 3 },
                new int[] { 5, -1 },
                new int[] { -2, 4 }
            };
            int k = 2;

            Assert.Equal(expected, new Solution().KClosest(points, k));
        }

        [Fact]
        public void Test3()
        {
            int[][] expected = new int[][]
            {
                new int[] { -2, -6 },
                new int[] { -7, -2 },
                new int[] { -8, 1 },
                new int[] { 2, 8 },
                new int[] { 10, 3 }
            };
            int[][] points = new int[][]
            {
                new int[] { -2, -6 },
                new int[] { -7, -2 },
                new int[] { -9, 6 },
                new int[] { 10, 3 },
                new int[] { -8, 1 },
                new int[] { 2, 8 }
            };
            int k = 5;

            Assert.Equal(expected, new Solution().KClosest(points, k));
        }
    }
}