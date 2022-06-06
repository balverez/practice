namespace CourseSchedule
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = true;
            int numCourses = 2;
            int[][] prerequisites = { new int[] { 1, 0 } };

            Assert.Equal(expected, new Solution().CanFinish(numCourses, prerequisites));
        }

        [Fact]
        public void Test2()
        {
            bool expected = true;
            int numCourses = 2;
            int[][] prerequisites = { new int[] { 0, 1 } };

            Assert.Equal(expected, new Solution().CanFinish(numCourses, prerequisites));
        }

        [Fact]
        public void Test3()
        {
            bool expected = false;
            int numCourses = 2;
            int[][] prerequisites = new int[][] 
            { 
                new int[] { 1, 0 },
                new int[] { 0, 1 }
            };

            Assert.Equal(expected, new Solution().CanFinish(numCourses, prerequisites));
        }

        [Fact]
        public void Test4()
        {
            bool expected = false;
            int numCourses = 3;
            int[][] prerequisites = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 0, 2 },
                new int[] { 2, 1 }
            };

            Assert.Equal(expected, new Solution().CanFinish(numCourses, prerequisites));
        }
    }
}