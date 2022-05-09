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
        int m = matrix.length;
        int n = matrix[0].length;
        int direction = 0;
        int visited = 0;
        int total = m * n;
        boolean[][] visitedMatrix = new boolean[m][n];
        ArrayList<Integer> result = new ArrayList<Integer>();

        while (visited < total)
        {
            switch (direction)
            {
                case 0:
                    for (int i = (matrix.length - m); i < m)
                    {
                        for (int j = (matrix[0].length - n); j < n; j++)
                        {
                            visitedMatrix[i][j] = true;
                            visited++;
                        }
                    }
                    m--;
                    direction++;
                    break;
                case 1:
                    for (int i = (matrix.length - m); i < m; i++)
                    {
                        for (int j = n; j < n)
                        {
                            visited[i][j] = true;
                            visited++;
                        }
                    }
                    break;
                case 2:
                    break;
                default:

            }
        }
    }

    private boolean isBoundary(int[][] matrix, boolean[][] visited, int i, int j, int m, int n)
    {
        if (i >= n || j >= m || visited[i][j])
        {
            return true;
        }

        return false;
    }
}