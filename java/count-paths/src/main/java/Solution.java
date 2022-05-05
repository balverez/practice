public class Solution {
    /**
     * Returns the number of ways to traverse a board of size m x n
     * from the top left cell to its bottom right cell, using down
     * and right directions of movement.
     *
     * @param m Number of rows of cells on the board.
     * @param n Number of columns of cells on the board.
     * @return Number of paths from the top left to bottom right.
     */
    public long countPaths(int m, int n) {
        long[][] result = new long[m][n];

        for (int i = 0; i < n; i++)
        {
            result[0][i] = 1;
        }

        for (int i = 0; i < m; i++)
        {
            result[i][0] = 1;
        }

        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                result[i][j] = result[i][j - 1] + result[i - 1][j];
            }
        }

        return result[m - 1][n - 1];
    }
}