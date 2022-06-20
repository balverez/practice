namespace WordLadder
{
    public class Solution
    {
        //O(n * k^2) time, where k is the length of the strings
        //O(n * k^2) space
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Any(s => s.Equals(endWord)))
                return 0;

            int length = beginWord.Length;
            Dictionary<string, List<string>> transformations = new();
            foreach (string word in wordList)
            {
                for (int i = 0; i < length; i++)
                {
                    string key = word[..i] + '*' + word[(i + 1)..];
                    transformations[key] = transformations.GetValueOrDefault(key, new());
                    transformations[key].Add(word);
                }
            }

            Queue<string> ladderSteps = new();
            ladderSteps.Enqueue(beginWord);
            Queue<string> newSteps = new();
            HashSet<string> visited = new();
            int numWords = 1;
            while (ladderSteps.Count > 0)
            {
                string step = ladderSteps.Dequeue();

                for (int i = 0; i < length; i++)
                {
                    string key = step[..i] + '*' + step[(i + 1)..];
                    if (transformations.ContainsKey(key))
                    {
                        foreach (string word in transformations[key])
                        {
                            if (!visited.Contains(word))
                            {
                                if (word.Equals(endWord))
                                    return ++numWords;

                                visited.Add(word);
                                newSteps.Enqueue(word);
                            }
                            
                        }
                    }
                }

                if (ladderSteps.Count == 0 && newSteps.Count > 0)
                {
                    numWords++;
                    ladderSteps = new(newSteps);
                    newSteps = new();
                }
            }

            return 0;
        }
    }
}