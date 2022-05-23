using System;
using System.Collections.Generic;

namespace TriangleMinSumPath
{
    internal class Solution
    {
        internal int TriangleMinPathSum(List<List<int>> triangle)
        {
            int k = triangle.Count;
            int[] memo = new int[k];

            for (int j = 0; j < triangle[k - 1].Count; j++)
            {
                memo[j] = triangle[k - 1][j];
            }

            for (int i = k - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Count; j++)
                {
                    memo[j] = triangle[i][j] + Math.Min(memo[j], memo[j + 1]);
                }
            }

            return memo[0];
        }
    }
}