namespace CourseScheduleII
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] expected = { 0, 1 };
            int numCourses = 2;
            int[][] prerequisites =
            {
                new int[] { 1, 0 }
            };

            Assert.Equal(expected, new Solution().FindOrder(numCourses, prerequisites));
        }

        [Fact]
        public void Test2()
        {
            int[] expected = { 0, 1, 2, 3 };
            int numCourses = 4;
            int[][] prerequisites =
            {
                new int[] { 1, 0 },
                new int[] { 2, 0 },
                new int[] { 3, 1 },
                new int[] { 3, 2 },
            };

            Assert.Equal(expected, new Solution().FindOrder(numCourses, prerequisites));
        }

        [Fact]
        public void Test3()
        {
            int[] expected = { 0 };
            int numCourses = 1;
            int[][] prerequisites = Array.Empty<int[]>();

            Assert.Equal(expected, new Solution().FindOrder(numCourses, prerequisites));
        }
    }
}