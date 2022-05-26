using System;
using System.Collections.Generic;

namespace LongestSubstringUniqueCharacters
{
    internal class Solution
    {
        internal int MaxSubstringLength(string input)
        {
            int maxLength = 0;
            Dictionary<char, int> slidingWindow = new();

            int tail = 0;
            for (int head = 0; head < input.Length; head++)
            {
                if (slidingWindow.ContainsKey(input[head]) && slidingWindow[input[head]] >= tail)
                {
                    tail = slidingWindow[input[head]] + 1;
                }

                maxLength = Math.Max(maxLength, head - tail + 1);
                slidingWindow[input[head]] = head;
            }

            return maxLength;
        }
    }
}
