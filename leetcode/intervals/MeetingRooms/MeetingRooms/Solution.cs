namespace MeetingRooms
{
    public class Solution
    {
        //O(nlogn) time
        //O(1) space
        public bool CanAttendMeetings(int[][] intervals)
        {
            Array.Sort(intervals, Comparer<int[]>.Create((int[] i, int[] j) => i[0].CompareTo(j[0])));

            for (int i = 1; i < intervals.Length; i++)
                if (intervals[i - 1][1] > intervals[i][0])
                    return false;

            return true;
        }
    }
}