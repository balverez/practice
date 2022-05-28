using System.Text;

namespace StringCompression
{
    internal class Solution
    {
        public string Compress(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            StringBuilder compressed = new();

            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                count++;
                if (i + 1 == input.Length || input[i] != input[i + 1])
                {
                    compressed.Append(input[i]);
                    if (count > 1)
                        compressed.Append(count);
                    count = 0;
                }
            }

            return compressed.ToString();
        }
    }
}
