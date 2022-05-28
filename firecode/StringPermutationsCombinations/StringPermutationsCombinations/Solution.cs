namespace StringPermutationsCombinations
{
    internal class Solution
    {
        internal HashSet<string> PermutationsAndCombinations(string str)
        {
            HashSet<string> combinations = Combinations(str);

            HashSet<string> result = new();
            foreach (string combination in combinations)
            {
                result.UnionWith(Permutations(combination));
            }
            
            return result;
        }

        //O(2^n) time
        //O(2^n) space
        private HashSet<string> Combinations(string str)
        {
            HashSet<string> combinations = new() { string.Empty };

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                HashSet<string> charCombinations = new();
                foreach (string combination in combinations)
                    charCombinations.Add(combination + c);

                combinations.UnionWith(charCombinations);
            }

            return combinations;
        }

        private HashSet<string> Permutations(string str)
        {
            HashSet<string> permutations = new();
            if (string.IsNullOrEmpty(str))
                return permutations;

            if (str.Length < 2)
            {
                permutations.Add(str);
                return permutations;
            }

            char first = str[0];
            HashSet<string> subPermutations = Permutations(str[1..]);

            foreach (string sub in subPermutations)
                permutations.UnionWith(SplicePermutation(first, sub));

            return permutations;
        }

        private HashSet<string> SplicePermutation(char c, string str)
        {
            HashSet<string> result = new();

            for (int i = 0; i <= str.Length; i++)
                result.Add(str[..i] + c + str[i..]);

            return result;
        }
    }
}
