namespace LetterCombinations
{
    public class Solution
    {
        public Dictionary<char, char[]> PhoneMap { get; } = new()
        {
            { '2', new char[] { 'a', 'b', 'c' } },
            { '3', new char[] { 'd', 'e', 'f' } },
            { '4', new char[] { 'g', 'h', 'i' } },
            { '5', new char[] { 'j', 'k', 'l' } },
            { '6', new char[] { 'm', 'n', 'o' } },
            { '7', new char[] { 'p', 'q', 'r', 's' } },
            { '8', new char[] { 't', 'u', 'v' } },
            { '9', new char[] { 'w', 'x', 'y', 'z' } },
        };

        public IList<string> LetterCombinations(string digits)
        {
            List<string> combinations = new();
            if (string.IsNullOrEmpty(digits))
                return combinations;

            Backtrack(combinations, digits, "", 0);

            return combinations;
        }

        private void Backtrack(List<string> combinations, string digits, string current, int i)
        {
            if (current.Length == digits.Length)
            {
                combinations.Add(current);
                return;
            }

            foreach (char letter in PhoneMap[digits[i]])
                Backtrack(combinations, digits, current + letter, i + 1);
        }
    }
}