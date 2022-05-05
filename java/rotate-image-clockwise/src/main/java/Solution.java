public class Solution
{
    /**
     * Returns a copy of the input image,
     * rotated clockwise by 90 degrees.
     *
     * @param image Input matrix.
     * @return Output image, rotated clockwise by 90 degrees.
     */
    public int[][] rotateClockwise(int[][] image)
    {
        return verticalFlip(transpose(image));
    }

    public int[][] transpose(int[][] image)
    {
        int[][] result = new int[image.length][image.length];

        for (int i = 0; i < result.length; i++)
        {
            for (int j = 0; j < result.length; j++)
            {
                result[i][j] = image[j][i];
            }
        }

        return result;
    }

    public int[][] verticalFlip(int[][] image)
    {
        int[][] result = new int[image.length][image.length];

        for (int i = 0; i < result.length; i++)
        {
            for (int j = (result.length - 1); j > -1; j--)
            {
                result[i][result.length - j - 1] = image[i][j];   
            }
        }

        return result;
    }
}