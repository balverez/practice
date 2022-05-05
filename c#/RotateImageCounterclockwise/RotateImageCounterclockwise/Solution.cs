using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateImageCounterclockwise
{
    internal class Solution
    {
        public int[,] RotateCounterclockwise(int[,] image) =>
            HorizantalFlip(Transpose(image));

        private int[,] Transpose(int[,] image)
        {
            int size = image.GetLength(0);
            int[,] transpose = new int[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    transpose[i, j] = image[j, i];

            return transpose;
        }

        private int[,] HorizantalFlip(int[,] image)
        {
            int size = image.GetLength(0);
            int[,] result = new int[size, size];

            for (int i = size - 1; i >= 0; i--)
                for (int j = 0; j < size; j++)
                    result[(size - i - 1), j] = image[i, j];

            return result;
        }
    }
}
