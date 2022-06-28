using System.Text;

namespace EncodeAndDecodeStrings
{
    public class Codec
    {
        //O(n) time
        //O(1) space
        public string encode(IList<string> strs)
        {
            StringBuilder result = new();

            foreach (string s in strs)
                result.Append($"{(char)s.Length}:{s}");

            return result.ToString();
        }

        //O(nk) time, where k is the max string length in the set
        //O(1) space
        public IList<string> decode(string s)
        {
            List<string> result = new();
            int start = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == ':')
                {
                    int length = s[start];
                    start = i + length + 1;
                    result.Add(s[(i + 1)..start]);
                    i = start;
                }
            }


            return result;
        }
    }
}