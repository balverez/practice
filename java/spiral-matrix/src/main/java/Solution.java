import java.util.ArrayList;
import java.util.List;

public class Solution
{
    /**
    * Returns the integers in the matrix in clockwise
    * spiral order.
    *
    * @param matrix Input matrix.
    * @return List of integers in clockwise spiral order.
    */
    public List<Integer> dumpSpiral(int[][] matrix)
    {
        List<Integer> result = new ArrayList<>();
        int m = matrix.length;
        int n = matrix[0].length;
        boolean[][] visited = new boolean[m][n];
        int[] rowIncrements = {0, 1, 0, -1};
        int[] colIncrements = {1, 0, -1, 0};

        int i = 0;
        int j = 0;
        int direction = 0;
        for (int k = 0; k < m * n; k++)
        {
            result.add(matrix[i][j]);
            visited[i][j] = true;
            int possibleRow = i + rowIncrements[direction];
            int possibleCol = j + colIncrements[direction];
            if (possibleRow >= 0
                && possibleRow < m
                && possibleCol >= 0
                && possibleCol < n
                && !visited[possibleRow][possibleCol])
            {
                i = possibleRow;
                j = possibleCol;
            }
            else
            {
                direction = (direction + 1) % 4;
                i += rowIncrements[direction];
                j += colIncrements[direction];
            }
        }

        return result;
    }
}