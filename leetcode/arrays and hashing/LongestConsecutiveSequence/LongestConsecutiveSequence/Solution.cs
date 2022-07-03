namespace LongestConsecutiveSequence
{
    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            int longest = 0;
            if (nums.Length == 0)
                return longest;

            HashSet<int> set = new();
            foreach (int i in nums)
                set.Add(i);

            foreach (int i in set)
            {
                if (!set.Contains(i - 1))
                {
                    int current = 0;
                    int j = i;
                    while (set.Contains(j))
                    {
                        current++;
                        j++;
                    }

                    longest = Math.Max(longest, current);
                }
            }

            return longest;
        }
    }
}