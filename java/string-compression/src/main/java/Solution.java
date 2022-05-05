public class Solution {
    /**
     * Compresses a sorted string by replacing adjacent identical
     * characters with their cardinality if it's >= 2.
     *
     * @param input Sorted string input.
     * @return Compressed string output.
     */
    public String compress(String input) {
        StringBuilder compressedString = new StringBuilder();

        int count = 0;
        int length = input.length();
        int i;
        for (i = 0; i < length; i++)
        {
            count++;

            if (i + 1 < length && input.charAt(i) != input.charAt(i + 1))
            {
                if (count > 1)
                {
                    compressedString.append(String.format("%c%d", input.charAt(i), count));
                }
                else
                {
                    compressedString.append(input.charAt(i));
                }

                count = 0;
            }
        }

        if (count > 1)
        {
            compressedString.append(String.format("%c%d", input.charAt(i - 1), count));
        }
        else if (length > 0)
        {
            compressedString.append(input.charAt(i - 1));
        }

        return compressedString.toString();
    }
  }