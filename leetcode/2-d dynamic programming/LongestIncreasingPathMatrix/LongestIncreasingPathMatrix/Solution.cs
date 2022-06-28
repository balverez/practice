namespace LongestIncreasingPathMatrix
{
    public class Solution
    {
        //O(mn) time
        //O(mn) space
        public int LongestIncreasingPath(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int max = int.MinValue;
            int[,] memo = new int[m, n];


            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    memo[i, j] = int.MinValue;
            
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    max = Math.Max(max, DFS(matrix, memo, i, j, m, n, int.MinValue));

            return max;
        }

        private int DFS(int[][] matrix, int[,] memo, int i, int j, int m, int n, int pathMax)
        {
            if (i < 0 || i >= m || j < 0 || j >= n || matrix[i][j] <= pathMax)
                return 0;

            if (memo[i, j] != int.MinValue)
                return memo[i, j];
            else
            {
                pathMax = matrix[i][j];
                int up = DFS(matrix, memo, i - 1, j, m, n, pathMax);
                int down = DFS(matrix, memo, i + 1, j, m, n, pathMax);
                int left = DFS(matrix, memo, i, j - 1, m, n, pathMax);
                int right = DFS(matrix, memo, i, j + 1, m, n, pathMax);

                memo[i, j] = 1 + Math.Max(Math.Max(up, down), Math.Max(left, right));

                return memo[i, j];
            }
        }
    }
}