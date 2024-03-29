﻿namespace SetMatrixZeroes
{
    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            bool firstRow = false;
            bool firstColumn = false;

            for (int i = 0; i < m; i++)
                if (matrix[i][0] == 0)
                    firstColumn = true;

            for (int j = 0; j < n; j++)
                if (matrix[0][j] == 0)
                    firstRow = true;

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                        matrix[i][j] = 0;

            if (firstRow)
                for (int j = 0; j < n; j++)
                    matrix[0][j] = 0;

            if (firstColumn)
                for (int i = 0; i < m; i++)
                    matrix[i][0] = 0;
        }
    }
}