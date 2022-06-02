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
            int right = m * n - 1;

            while (left <= right)
            {
                int pivot = (left + right) / 2;
                int pivotElement = matrix[pivot / n][pivot % n];
                
                if (pivotElement == target)
                    return true;

                if (pivotElement < target)
                    left = pivot + 1;
                else
                    right = pivot - 1;
            }

            return false;
        }
    }
}