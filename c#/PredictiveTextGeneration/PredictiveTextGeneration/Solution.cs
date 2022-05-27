using System.Linq;

namespace PredictiveTextGeneration
{
    internal class Solution
    {
        //O(n!) time
        //O(n!) space
        private readonly Dictionary<char, string> _keyMap = new()
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" },
        };

        internal HashSet<string> GenerateStrings(string digits)
        {
            HashSet<string> permutations = new();
            if (digits.Length < 2)
                return new(_keyMap[digits[0]].Select(c => c.ToString()));

            char first = digits[0];
            HashSet<string> subPermutations = GenerateStrings(digits[1..]);
            foreach (char c in _keyMap[first])
                foreach (string subPermutation in subPermutations)
                    permutations.Add(c + subPermutation);
                

            return permutations;
        }
    }
}