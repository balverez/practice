namespace MutateDnaPairs
{
    internal class Solution
    {
        internal string MutateDnaPairs(string sequence)
        {
            if (sequence.Length < 2)
                return sequence;

            return sequence[0] == sequence[1]
                ? sequence[0] + "G" + MutateDnaPairs(sequence[1..])
                : sequence[0] + MutateDnaPairs(sequence[1..]);
        }
    }
}