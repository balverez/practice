namespace Search2DMatrix
{
    public class Solution
    {
        //O(log(m * n)) time
        //O(1) space
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int left = 0;
            int right = (m * n) - 1;
            while (left <= right)
            {
                int p = (left + right) >> 1;
                int element = matrix[p / n][p % n];

                if (element == target)
                    return true;

                if (target < element)
                    right = p - 1;
                else
                    left = p + 1;
            }

            return false;
        }
    }
}