 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorImage
{
    public class Solution
    {
        //O(m * n) time
        //O(m * n) space
        public int[,] MirrorImage(int[,] image)
        {
            int m = image.GetLength(0);
            int n = image.GetLength(1);

            int[,] result = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j  < n; j++)
                    result[i, j] = image[i, n - j - 1];

            return result;
        }
    }
}
