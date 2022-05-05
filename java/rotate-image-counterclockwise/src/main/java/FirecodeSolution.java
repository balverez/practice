import java.util.stream.IntStream;

public class FirecodeSolution {
  /**
   * Returns a copy of the input image,
   * rotated counterclockwise by 90 degrees.
   *
   * @param image Input matrix.
   * @return Output image, rotated counterclockwise by 90 degrees.
   */
  public int[][] rotateCounterClockwise(int[][] image) {
    return flipOnHorizontalAxis(transpose(image));
  }

  /**
   * Returns the transpose of the input matrix.
   *
   * @param image Input matrix.
   * @return Transpose of the input matrix.
   */
  private int[][] transpose(int[][] image) {
    int size = image.length;
    int[][] transposed = new int[size][size];
    for (int row = 0; row < size; row++) {
      for (int col = 0; col < size; col++) {
        transposed[row][col] = image[col][row];
      }
    }
    return transposed;
  }

  /**
   * Returns a copy of the input matrix, flipped on its horizontal axis.
   *
   * @param image Input matrix.
   * @return Copy of the input matrix, flipped on its horizontal axis.
   */
  private int[][] flipOnHorizontalAxis(int[][] image) {
    return IntStream
             .range(0, image.length)
             .mapToObj(i -> image[image.length - 1 - i])
             .toArray(int[][]::new);
  }
}