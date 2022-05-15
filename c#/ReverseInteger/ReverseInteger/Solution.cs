namespace ReverseInteger
{
    internal class Solution
    {
        public int Reverse(int input)
        {
            int reversed = 0;

            while (input > 0)
            {
                reversed = (reversed * 10) + (input % 10);
                input /= 10;
            }

            return reversed;
        }
    }
}
