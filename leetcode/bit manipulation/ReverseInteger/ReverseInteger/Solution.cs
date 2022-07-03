namespace ReverseInteger
{
    public class Solution
    {
        //O(logx) time
        //(1) space
        public int Reverse(int x)
        {
            int reverse = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if ((reverse > int.MaxValue / 10 || (reverse == int.MaxValue / 10 && pop > 7))
                    || (reverse < int.MinValue / 10 || (reverse == int.MinValue / 10 && pop < -8)))
                    return 0;

                reverse = (reverse * 10) + pop;
            }

            return reverse;
        }
    }
}