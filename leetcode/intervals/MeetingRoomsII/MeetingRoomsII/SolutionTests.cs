namespace MeetingRoomsII
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            int expected = 2;
            int[][] intervals =
            {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 }
            };

            Assert.Equal(expected, new Solution().MinMeetingRooms(intervals));
        }

        [Fact]
        public void Test2()
        {
            int expected = 1;
            int[][] intervals =
            {
                new int[] { 7, 10 },
                new int[] { 2, 4 }
            };

            Assert.Equal(expected, new Solution().MinMeetingRooms(intervals));
        }

        [Fact]
        public void Test3()
        {
            int expected = 2;
            int[][] intervals =
            {
                new int[] { 9, 10 },
                new int[] { 4, 9 },
                new int[] { 4, 17 }
            };

            Assert.Equal(expected, new Solution().MinMeetingRooms(intervals));
        }
    }
}