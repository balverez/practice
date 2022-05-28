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

            if (sum == 0)
                return true;
            else if (sum % 2 != 0)
                return false;

            return Search(input, sum / 2, 0);    
        }

        private bool Search(int[] input, int target, int i)
        {
            if (i >= input.Length)
                return target == 0;
            else if (target == 0)
                return true;

            return Search(input, target, i + 1) || Search(input, target - input[i], i + 1);
        }
    }
}