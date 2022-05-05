public class FirecodeSolution {
  /**
   * Mutates the input DNA sequence and inserts G
   * in between adjacent identical letters.
   *
   * @param sequence Input sequence string.
   * @return Output mutated sequence string.
   */
  public String mutateDnaPairs(String sequence) {
    if (sequence.length() <= 1) {
      return sequence;
    }
    return sequence.charAt(0) +
        (sequence.charAt(0) == sequence.charAt(1) ? "G" : "") +
        mutateDnaPairs(sequence.substring(1));
  }
}