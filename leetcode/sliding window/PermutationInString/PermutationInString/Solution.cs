namespace PermutationInString
{
    public class Solution
    {
        //O(n) time
        //O(1) space
        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;

            int[] s1Counts = new int[26];
            int[] s2Counts = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                s1Counts[s1[i] - 'a']++;
                s2Counts[s2[i] - 'a']++;
            }

            int matches = 0;
            for (int i = 0; i < 26; i++)
                if (s1Counts[i] == s2Counts[i])
                    matches++;

            int tail = 0;
            for (int head = s1.Length; head < s2.Length; head++)
            {
                if (matches == 26)
                    return true;

                int i = s2[head] - 'a';
                s2Counts[i]++;
                if (s1Counts[i] == s2Counts[i])
                    matches++;
                else if (s1Counts[i] + 1 == s2Counts[i])
                    matches--;

                i = s2[tail] - 'a';
                s2Counts[i]--;
                if (s1Counts[i] == s2Counts[i])
                    matches++;
                else if (s1Counts[i] - 1 == s2Counts[i])
                    matches--;
                tail++;
            }

            return matches == 26;
        }
    }
}