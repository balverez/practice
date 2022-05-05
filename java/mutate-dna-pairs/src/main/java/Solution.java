public class Solution {
    /**
     * Mutates the input DNA sequence and inserts G
     * in between adjacent identical letters.
     *
     * @param sequence Input sequence string.
     * @return Output mutated sequence string.
     */
    public String mutateDnaPairs(String sequence) {
        if (sequence.length() < 2)
        {
            return sequence;
        }

        char c = sequence.charAt(0);
        if (c == sequence.charAt(1))
        {
            return Character.toString(c) + "G" + mutateDnaPairs(sequence.substring(1));
        }
        else
        {
            return Character.toString(c) + mutateDnaPairs(sequence.substring(1));
        }
    }
  }