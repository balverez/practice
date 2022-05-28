namespace DecimalToBinary
{
    internal class Solution
    {
        internal string ToBinary(int integer)
        {
            if (integer == 0)
                return string.Empty;

            return ToBinary(integer / 2) + (integer % 2).ToString();
        }
    }
}