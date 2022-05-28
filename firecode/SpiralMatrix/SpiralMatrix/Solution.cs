using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    internal class Solution
    {
        public List<int> DumpSpiral(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            List<int> result = new();
            bool[,] visited = new bool[m, n];
            int entries = m * n;
            int[] rowDirections = new int[4] { 0, 1, 0, -1 };
            int[] columnDirections = new int[4] { 1, 0, -1, 0 };

            int direction = 0;
            int i = 0;
            int j = 0;
            for (int k = 0; k < entries; k++)
            {
                result.Add(matrix[i, j]);
                visited[i, j] = true;
                int potentialRow = i + rowDirections[direction];
                int potentialColumn = j + columnDirections[direction];

                if (potentialRow >= 0
                    && potentialRow < m
                    && potentialColumn >= 0
                    && potentialColumn < n
                    && !visited[potentialRow, potentialColumn])
                {
                    i = potentialRow;
                    j = potentialColumn;
                }
                else
                {
                    direction = (direction + 1) % 4;
                    i += rowDirections[direction];
                    j += columnDirections[direction];
                }
            }

            return result;
        }
    }
}
