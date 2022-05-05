using System.Text;

namespace StringCompression
{
    internal class Solution
    {
        public string Compress(string input)
        {
            StringBuilder compressedString = new();

            int accumulator = 0;
            for (int i = 0; i < input.Length; i++)
            {
                accumulator++;
                if (i + 1 == input.Length || input[i] != input[i + 1])
                {
                    compressedString.Append(input[i]);
                    if (accumulator > 1)
                        compressedString.Append(accumulator);

                    accumulator = 0;
                }
            }

            return compressedString.ToString();
        }
    }
}
