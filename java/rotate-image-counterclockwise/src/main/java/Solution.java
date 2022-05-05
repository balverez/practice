import java.util.stream.IntStream;

public class Solution {
  /**
   * Returns a copy of the input image,
   * rotated counterclockwise by 90 degrees.
   *
   * @param image Input matrix.
   * @return Output image, rotated counterclockwise by 90 degrees.
   */
  public int[][] rotateCounterClockwise(int[][] image) {
      int[][] transpose = new int[image.length][image.length];

      for (int i = 0; i < transpose.length; i++)
      {
          for (int j = 0; j < transpose.length; j++)
          {
              transpose[j][i] = image[i][j];
          }
      }

      int[][] result = new int[image.length][image.length];

      for (int i = result.length - 1; i > -1; i--)
      {
          for (int j = 0; j < result.length; j++)
          {
              result[result.length - 1 - i][j] = transpose[i][j];
          }
      }
      
      return result;
  }
}
