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
            else
            {
                string first = str[0].ToString();

                HashSet<string> remainderPermutations = Permutations(str[1..]);
                if (remainderPermutations.Count == 0)
                    return new() { first };

                foreach (string remainingPermutation in remainderPermutations)
                {
                    foreach (string permutation in InsertChar(first, remainingPermutation))
                    {
                        permutations.Add(permutation);
                    }
                }

                return permutations;
            }
        }

        private HashSet<string> InsertChar(string c, string str)
        {
            HashSet<string> result = new();

            for (int i = 0; i <= str.Length; i++)
            {
                result.Add(str[0..i] + c + str[i..]);
            }

            return result;
        }
    }
}