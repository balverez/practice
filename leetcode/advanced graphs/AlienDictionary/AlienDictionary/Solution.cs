namespace AlienDictionary
{
    public class Solution
    {
        //O(nk) time, where n is the number of words and k is the average number of characters.
        //O(V + E) space, where V is the number of unique characters.
        public string AlienOrder(string[] words)
        {
            //O(nk) time, where n is the number of words and k is the average number of characters.
            //O(V) space, where V is the number of unique characters.
            Dictionary<char, List<char>> adjList = new();
            foreach (string s in words)
                foreach (char c in s)
                    if (!adjList.ContainsKey(c))
                        adjList[c] = new();

            //O(nk) time.
            //O(E) space, where E is the number of lexicographical relations.
            for (int i = 0; i < words.Length - 1; i++)
            {
                string s1 = words[i];
                string s2 = words[i + 1];
                if (s1.Length > s2.Length && s1.StartsWith(s2))
                    return string.Empty;

                for (int j = 0; j < Math.Min(s1.Length, s2.Length); j++)
                {
                    if (s1[j] != s2[j])
                    {
                        adjList[s1[j]].Add(s2[j]);
                        break;
                    }
                }
            }

            //O(V + E) time
            Dictionary<char, bool> completed = new();
            string result = string.Empty;
            foreach (char c in adjList.Keys)
                if (!TopologicalSort(adjList, completed, c, ref result))
                    return string.Empty;

            return string.Join(string.Empty, result.Reverse());
        }

        private bool TopologicalSort(Dictionary<char, List<char>> adjList, Dictionary<char, bool> completed, char c, ref string result)
        {
            if (completed.ContainsKey(c))
                return completed[c];

            completed[c] = false;
            foreach (char neighbor in adjList[c])
                if (!TopologicalSort(adjList, completed, neighbor, ref result))
                    return false;

            completed[c] = true;
            result += c;
            return true;
        }
    }
}