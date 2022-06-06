namespace MeetingRooms
{
    public class SolutionTests
    {
        [Fact]
        public void Test1()
        {
            bool expected = false;
            int[][] intervals = new int[][]
            {
                new int[] { 0, 30 },
                new int[] { 5, 10 },
                new int[] { 15, 20 }
            };

            Assert.Equal(expected, new Solution().CanAttendMeetings(intervals));
        }

        [Fact]
        public void Test2()
        {
            bool expected = true;
            int[][] intervals = new int[][]
            {
                new int[] { 7, 10 },
                new int[] { 2, 4 }
            };

            Assert.Equal(expected, new Solution().CanAttendMeetings(intervals));
        }
    }
}