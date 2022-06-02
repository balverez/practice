namespace RotateImage
{
    public class Solution
    {
        //O(m * n) time
        //O(1) space
        public void Rotate(int[][] matrix)
        {
            Transpose(matrix);
            VerticalFlip(matrix);
        }

        private void Transpose(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
                for (int j = i + 1; j < matrix.Length; j++)
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
        }

        private void VerticalFlip(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix.Length / 2; j++)
                    (matrix[i][j], matrix[i][matrix.Length - j - 1]) = (matrix[i][matrix.Length - j - 1], matrix[i][j]);
        }
    }
}