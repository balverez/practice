public class FirecodeSolution {
  /**
   * Takes in an input image and outputs a version flipped on its vertical
   * axis.
   *
   * @param image Image as a two dimensional array
   * @return Image flipped on its vertical axis
   */
  public int[][] mirrorImage(int[][] image) {
    int numRows = image.length, numCols = image[0].length;
    int[][] mirrorImage = new int[numRows][numCols];
    for (int row = 0; row < numRows; row++) {
      for (int col = 0; col < numCols; col++) {
        mirrorImage[row][col] = image[row][numCols - 1 - col];
      }
    }
    return mirrorImage;
  }
}
