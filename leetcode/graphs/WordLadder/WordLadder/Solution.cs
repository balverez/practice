namespace WordLadder
{
    public class Solution
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            Dictionary<int, List<string>> diffMap = new();
            bool endWordPresent = MapDifferences(endWord, diffMap, wordList);

            if (!endWordPresent)
                return 0;

            int diff = Difference(beginWord, endWord);

            List<string> ladder = new() { beginWord };
            string iterator = beginWord;
            while (diff > 0)
            {
                foreach (string word in diffMap[diff - 1])
                    if (Difference(word, iterator) == 1)
                    {
                        ladder.Add(word);
                        diff--;
                        continue;
                    }

                foreach (string word in)
            }
        }

        //O(n * k) time
        //O(n) space
        private static bool MapDifferences(string endWord, Dictionary<int, List<string>> diffMap, IList<string> wordList)
        {
            bool endWordPresent = false;
            foreach (string word in wordList)
            {
                if (word.Equals(endWord))
                    endWordPresent = true;

                int differences = Difference(word, endWord);

                if (!diffMap.ContainsKey(differences))
                    diffMap[differences] = new();

                diffMap[differences].Add(word);
            }

            return endWordPresent;
        }

        //O(k) time
        //O(1) space
        private static int Difference(string s1, string s2)
        {
            int diff = 0;
            for (int i = 0; i < s2.Length; i++)
                if (!s2[i].Equals(s1[i]))
                    diff++;

            return diff;
        }
    }
}