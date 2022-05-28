using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpose
{
    internal class Solution
    {
        public int[,] Transpose(int[,] image)
        {
            int size = image.GetLength(0);
            int[,] transpose = new int[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    transpose[i, j] = image[j, i];

            return transpose;
        }
    }
}
