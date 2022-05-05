public class Solution {
    /**
     * Takes in an input image and outputs a version flipped on its vertical
     * axis.
     *
     * @param image Image as a two dimensional array
     * @return Image flipped on its vertical axis
     */
    public int[][] mirrorImage(int[][] image)
    {
        int rows = image.length;
        int columns = image[0].length;
        int[][] result = new int[rows][columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i][j] = image[i][columns - 1 - j];    
            }
        }

        return result;
    }
}
