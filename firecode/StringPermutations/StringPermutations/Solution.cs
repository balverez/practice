using System.Collections.Generic;

namespace StringPermutations
{
    internal class Solution
    {
        //O(n * n!) time
        //O(n!) space
        internal HashSet<string> Permutations(string str)
        {
            HashSet<string> permutations = new();

            if (string.IsNullOrEmpty(str))
                return permutations;
            if (str.Length == 1)
            {
                permutations.Add(str[0].ToString());
                return permutations;
            }

            HashSet<string> subPermutations = Permutations(str[1..]);

            foreach (string sub in subPermutations)
            {
                List<string> splicedStrings = SpliceChar(str[0], sub);
                
                foreach (string permutation in splicedStrings)
                    permutations.Add(permutation);
            }

            return permutations;
        }

        private List<string> SpliceChar(char c, string permutation)
        {
            List<string> result = new();

            for (int i = 0; i <= permutation.Length; i++)
                result.Add(permutation[..i] + c + permutation[i..]);

            return result;
        }
    }
}