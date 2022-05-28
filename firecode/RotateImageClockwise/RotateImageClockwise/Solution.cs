using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateImageClockwise
{
    internal class Solution
    {
        public int[,] RotateClockwise(int[,] image) =>
            VerticalFlip(Transpose(image));

        private int[,] Transpose(int[,] image)
        {
            int size = image.GetLength(0);
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    result[i, j] = image[j, i];

            return result;
        }

        private int[,] VerticalFlip(int[,] image)
        {
            int size = image.GetLength(0);
            int[,] result = new int[size, size];

            for (int i = 0; i < size; i++)
                for (int j = size - 1; j >= 0; j--)
                    result[i, size - j - 1] = image[i, j];

            return result;
        }
    }
}
