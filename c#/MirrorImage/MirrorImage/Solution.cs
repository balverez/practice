 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorImage
{
    public class Solution
    {
        public int[,] MirrorImage(int[,] image)
        {
            int rows = image.GetLength(0);
            int columns = image.GetLength(1);
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i,j] = image[i, columns - 1 - j];
                }
            }

            return result;
        }
    }
}
