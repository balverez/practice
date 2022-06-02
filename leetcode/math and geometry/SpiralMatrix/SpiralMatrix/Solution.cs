namespace SpiralMatrix
{
    public class Solution
    {
        //O(m * n) time
        //O(1) space
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> order = new();
            int m = matrix.Length;
            int n = matrix[0].Length;

            int[] rowDirection = { 0, 1, 0, -1 };
            int[] columnDirection = { 1, 0, -1, 0 };

            int i = 0;
            int j = 0;
            int d = 0;
            for(int k = 0; k < m * n; k++)
            {
                order.Add(matrix[i][j]);
                matrix[i][j] = int.MinValue;

                int possibleRow = i + rowDirection[d];
                int possibleColumn = j + columnDirection[d];

                if (possibleRow < 0 || possibleRow >= m || possibleColumn < 0 || possibleColumn >= n || matrix[possibleRow][possibleColumn] == int.MinValue)
                {
                    d = ++d % rowDirection.Length;
                    i += rowDirection[d];
                    j += columnDirection[d];
                }
                else
                {
                    i = possibleRow;
                    j = possibleColumn;
                }
            }

            return order;
        }
    }
}