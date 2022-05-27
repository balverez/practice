namespace RotateImageCounterclockwise
{
    internal class Solution
    {
        public int[,] RotateCounterclockwise(int[,] image) => HorizontalFlip(Transpose(image)); 

        private int[,] Transpose(int[,] image)
        {
            int m = image.GetLength(0);
            int n = image.GetLength(1);
            int[,] transpose = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    transpose[i, j] = image[j, i];

            return transpose;
        }

        private int[,] HorizontalFlip(int[,] image)
        {
            int m = image.GetLength(0);
            int n = image.GetLength(1);
            int[,] flipped = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    flipped[m - i - 1, j] = image[i, j];

            return flipped;
        }
    }
}