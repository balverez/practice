using System;
using System.Linq;

namespace FlipImage
{
    public class Solution
    {
        public int[,] FlipImage(int[,] image)
        {
            int m = image.GetLength(0);
            int n = image.GetLength(1);
            int[,] result = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    result[i, j] = image[m - i - 1, j];

            return result;
        }
    }
}
