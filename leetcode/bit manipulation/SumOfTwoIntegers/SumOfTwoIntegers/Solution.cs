namespace SumOfTwoIntegers
{
    public class Solution
    {
        //O(1) time
        //O(1) space
        public int GetSum(int a, int b)
        {
            while (b != 0)
            {
                int carry = (a & b) << 1;
                a ^= b;
                b = carry;
            }

            return a;
        }
    }
}