import java.util.stream.IntStream;

public class Solution {
    /**
     * Takes in an input image and outputs a version flipped on its horizontal
     * axis.
     *
     * @param image Image as a two dimensional array
     * @return Image flipped on its horizontal axis
     */
    public int[][] flipImage(int[][] image) {
        return IntStream
            .range(0, image.length)
            .mapToObj(i -> image[image.length - 1 - i])
            .toArray(int[][]::new);
    }
}