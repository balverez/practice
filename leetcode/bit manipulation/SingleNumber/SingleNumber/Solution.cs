namespace SingleNumber
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public int SingleNumber(int[] nums)
        {
            int bitmask = 0;
            foreach (int i in nums)
                bitmask ^= i;

            return bitmask;
        }
    }
}