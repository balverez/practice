public class Solution {
    /**
     * Returns the transpose of the input square image.
     *
     * @param image Image as a two dimensional array.
     * @return Transposed image.
     */
    public int[][] transpose(int[][] image) {
        int[][] result = new int[image.length][image.length];

        for (int i = 0; i < image.length; i++) {
            for (int j = 0; j < image.length; j++) {
                result[i][j] = i == j ? image[i][j] : image[j][i];
            }
        }

        return result;
    }
}
