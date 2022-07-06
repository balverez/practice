namespace CheapestFlightsWithinKStops
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 700;
            int n = 4;
            int[][] flights =
            {
                new int[] { 0, 1, 100 },
                new int[] { 1, 2, 100 },
                new int[] { 2, 0, 100 },
                new int[] { 1, 3, 600 },
                new int[] { 2, 3, 200 }
            };
            int src = 0;
            int dst = 3;
            int k = 1;

            Assert.Equal(expected, new Solution().FindCheapestPrice(n, flights, src, dst, k));
        }

        [Fact]
        public void Test2()
        {
            int expected = 200;
            int n = 3;
            int[][] flights =
            {
                new int[] { 0, 1, 100 },
                new int[] { 1, 2, 100 },
                new int[] { 0, 2, 500 }
            };
            int src = 0;
            int dst = 2;
            int k = 1;

            Assert.Equal(expected, new Solution().FindCheapestPrice(n, flights, src, dst, k));
        }

        [Fact]
        public void Test3()
        {
            int expected = 500;
            int n = 3;
            int[][] flights =
            {
                new int[] { 0, 1, 100 },
                new int[] { 1, 2, 100 },
                new int[] { 0, 2, 500 }
            };
            int src = 0;
            int dst = 2;
            int k = 0;

            Assert.Equal(expected, new Solution().FindCheapestPrice(n, flights, src, dst, k));
        }

        [Fact]
        public void Test4()
        {
            int expected = 500;
            int n = 4;
            int[][] flights =
            {
                new int[] { 0, 1, 100 },
                new int[] { 1, 3, 500 },
                new int[] { 0, 2, 200 },
                new int[] { 1, 3, 500 },
                new int[] { 2, 3, 300 }
            };
            int src = 0;
            int dst = 3;
            int k = 1;

            Assert.Equal(expected, new Solution().FindCheapestPrice(n, flights, src, dst, k));
        }

        [Fact]
        public void Test5()
        {
            int expected = 14;
            int n = 10;
            int[][] flights =
            {
                new int[] { 3,4,4 },
                new int[] { 2,5,6 },
                new int[] { 4,7,10},
                new int[] { 9,6,5 },
                new int[] { 7,4,4 },
                new int[] { 6,2,10 },
                new int[] { 6,8,6 },
                new int[] { 7,9,4 },
                new int[] { 1,5,4 },
                new int[] { 1,0,4 },
                new int[] { 9,7,3 },
                new int[] { 7,0,5 },
                new int[] { 6,5,8 },
                new int[] { 1,7,6 },
                new int[] { 4,0,9 },
                new int[] { 5,9,1 },
                new int[] { 8,7,3 },
                new int[] { 1,2,6 },
                new int[] { 4,1,5 },
                new int[] { 5,2,4 },
                new int[] { 1,9,1 },
                new int[] { 7,8,10 },
                new int[] { 0,4,2 },
                new int[] { 7,2,8 }
            };
            int src = 6;
            int dst = 0;
            int k = 7;

            Assert.Equal(expected, new Solution().FindCheapestPrice(n, flights, src, dst, k));
        }

        [Fact]
        public void Test6()
        {
            int expected = 7;
            int n = 5;
            int[][] flights =
            {
                new int[] { 0,1,5 },
                new int[] { 1,2,5 },
                new int[] { 0,3,2 },
                new int[] { 3,1,2 },
                new int[] { 1,4,1 },
                new int[] { 4,2,1 }
            };
            int src = 0;
            int dst = 2;
            int k = 2;

            Assert.Equal(expected, new Solution().FindCheapestPrice(n, flights, src, dst, k));
        }
    }
}