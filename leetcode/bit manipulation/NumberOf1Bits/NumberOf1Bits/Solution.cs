namespace NumberOf1Bits
{
    public class Solution
    {
        //O(1) time
        //O(1) space
        public int HammingWeight(int n)
        {
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= n - 1;
            }

            return count;
        }
    }
}