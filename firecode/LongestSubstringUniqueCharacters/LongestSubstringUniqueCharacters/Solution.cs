using System;
using System.Collections.Generic;

namespace LongestSubstringUniqueCharacters
{
    internal class Solution
    {
        internal int MaxSubstringLength(string input)
        {
            int maxLength = int.MinValue;
            Dictionary<char, int> charMap = new();

            int tail = 0;
            for (int head = 0; head < input.Length; head++)
            {
                if (charMap.ContainsKey(input[head]) && charMap[input[head]] >= tail)
                {
                    tail = charMap[input[head]] + 1;
                }

                maxLength = Math.Max(maxLength, head - tail + 1);

                charMap[input[head]] = head;
            }

            return maxLength;
        }
    }
}