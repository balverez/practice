using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpose
{
    internal class Solution
    {
        public int[,] TransposeMatrix(int[,] arr)
        {
            int length = arr.GetLength(0);
            int[,] transpose = new int[length, length];

            for (int i = 0; i < length; i++)
                for (int j = 0; j < length; j++)
                    transpose[i, j] = arr[j, i];

            return transpose;
        }
    }
}
