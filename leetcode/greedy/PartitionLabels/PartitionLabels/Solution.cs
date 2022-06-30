namespace PartitionLabels
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public IList<int> PartitionLabels(string s)
        {
            List<int> partitions = new();
            Dictionary<char, int> charMap = new();
            foreach (char c in s)
                charMap[c] = charMap.GetValueOrDefault(c, 0) + 1;

            int zeroCount = 0;
            int partition = 0;
            HashSet<char> windowChars = new();
            foreach (char c in s)
            {
                if (!windowChars.Contains(c))
                    windowChars.Add(c);

                partition++;
                charMap[c]--;

                if (charMap[c] == 0)
                    zeroCount++;

                if (zeroCount == windowChars.Count)
                {
                    partitions.Add(partition);
                    partition = 0;
                    zeroCount = 0;
                    windowChars = new();
                }
            }

            return partitions;
        }
    }
}