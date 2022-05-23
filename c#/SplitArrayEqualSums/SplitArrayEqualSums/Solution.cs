using System.Linq;

namespace SplitArrayEqualSums
{
    internal class Solution
    {
        //O(2^n) time
        //O(n) space
        internal bool EvenSplit(int[] input)
        {
            int sum = input.Sum();

            if (sum % 2 != 0)
            {
                return false;
            }

            return Search(input, 0, sum / 2);
        }

        private bool Search(int[] input, int i, int target)
        {
            if (i == input.Length)
                return target == 0;
            else if (target == 0)
                return true;

            return Search(input, i + 1, target - input[i]) || Search(input, i + 1, target);
        }
    }
}