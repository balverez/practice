namespace MinimumWindowSubstring
{
    public class Solution
    {
        //O(n + m) time, where n is the length of the string and m is the length of the substring.
        //O(n + m) space, where m is the length of the substring.
        public string MinWindow(string s, string t)
        {
            int m = s.Length;
            int n = t.Length;
            if (m < n || m == 0 || n == 0)
                return string.Empty;

            Dictionary<char, int> counts = new();
            foreach (char c in t)
                counts[c] = counts.GetValueOrDefault(c, 0) + 1;

            Dictionary<char, int> window = new();
            int required = counts.Count;
            int contains = 0;
            int left = 0;
            int[] result = { -1, 0, 0 };
            for (int right = 0;  right < m; right++)
            {
                char c = s[right];
                window[c] = window.GetValueOrDefault(c, 0) + 1;

                if (counts.ContainsKey(c) && counts[c] == window[c])
                    contains++;

                while (left <= right && contains == required)
                {
                    c = s[left];
                    if (result[0] == - 1 || right - left + 1 < result[0])
                    {
                        result[0] = right - left + 1;
                        result[1] = left;
                        result[2] = right;
                    }

                    window[c]--;
                    if (counts.ContainsKey(c) && window[c] < counts[c])
                        contains--;

                    left++;
                }
            }

            return result[0] == -1 ? string.Empty : s[result[1]..(result[2] + 1)];
        }
    }
}