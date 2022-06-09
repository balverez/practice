using System.Collections.Generic;

namespace GoogleOTS
{
    internal class Solution
    {
        internal List<int> CutString(string input, int x, int y)
        {
            List<int> result = new();
            Dictionary<char, int> map = new();
            map['A'] = 0;
            map['B'] = 0;

            for (int i = 0; i < input.Length; i++)
            {
                map[input[i]]++;

                if (map['A'] > x || map['B'] > y)
                {
                    map['A'] = 0;
                    map['B'] = 0;
                    result.Add(i);
                }
                else if (map['A'] == x && map['B'] == y)
                {
                    return new() { i + 1 };
                }
            }

            return result;
        }
    }
}
