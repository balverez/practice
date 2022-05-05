public class FirecodeSolution {
  /**
   * Returns the transpose of the input square image.
   *
   * @param image Image as a two dimensional array.
   * @return Transposed image.
   */
  public int[][] transpose(int[][] image) {
    int size = image.length;
    int[][] transposed = new int[size][size];
    for (int row = 0; row < size; row++) {
      for (int col = 0; col < size; col++) {
        transposed[row][col] = image[col][row];
      }
    }
    return transposed;
  }
}
