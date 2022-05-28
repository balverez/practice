namespace BetterRecursivePower
{
    internal class Solution
    {
        //O(logn) time
        //O(logn) space
        internal double BetterPower(double b, int x)
        {
            if (x == 0)
                return 1D;
            else if (x % 2 == 0)
                return x < 0
                    ? BetterPower(1 / (b * b), -x / 2)
                    : BetterPower(b * b, x / 2);

            return x < 0
                ? BetterPower(1 / b, -x)
                : b * BetterPower(b, x - 1);
        }
    }
}